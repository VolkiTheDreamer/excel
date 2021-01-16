import pandas as pd
import difflib
import sys ,os,psutil
import json

try:
    ppid = os.getppid() 
    starter=psutil.Process(ppid).name()

    if (starter=="cmd.exe"):
        sourceworkbook=r"E:\OneDrive\Dökümanlar\GitHub\dotnet\Ugulamalar\InvestPY\Terim Listesi.xlsx"
        kolon="Terimler"
        esik=80
        targetfile=r"C:\Invest\fuzzy.xlsx"
        istisnaJson='{"artan":"azalan" , "tl":"yp", "aktif":"inaktif"}'
    else:
        sourceworkbook=sys.argv[1]
        kolon=sys.argv[2]        
        esik=int(sys.argv[3]) 
        targetfile=sys.argv[4]       
        istisnaJson=sys.argv[5]
        
    try:        
        liste=[]        
        eklenecek=True
        exceptions=json.loads(istisnaJson)
        df = pd.read_excel(sourceworkbook)
        terimler=pd.Series(df[kolon].unique()).apply(lambda x:x.replace("İ","i").lower())
        for t1 in terimler:
            for t2 in terimler:
                if t1 != t2:
                    for k,v in exceptions.items():
                        if (((k in t1) and (v in t2)) or ((v in t1) and (k in t2))):
                            eklenecek=False
                            break

                    if eklenecek==True:
                        seq=difflib.SequenceMatcher(None,t1,t2) 
                        d=seq.ratio()*100
                        
                        if d>esik:
                            if not [t2,t1,d] in liste: #sol-sağ ellendiyse sağ-sol eklenmesin
                                liste.append([t1,t2,d])
                else:
                    continue
                continue

        yenidf=pd.DataFrame(liste)
        yenidf.to_excel(targetfile)
        print("işlem tamam")
    except Exception as e:
        print("İç try",str(e))
except Exception as e:
    print("Dış try",str(e))