import pandas as pd
import investpy
import sys

try:    
    bas=sys.argv[1] #'01/01/2020'
    bts=sys.argv[2] #'02/01/2020'
    dosya=sys.argv[3]

    #stocks
    anadf=pd.DataFrame()
    for c in ["turkey"]: #investpy.get_stock_countries():
        for s in investpy.get_stocks_list(country=c)[:10]:
            try:
                df = investpy.get_stock_historical_data(stock=s,country=c,from_date=bas,to_date=bts)
                df["stok"]=s
                df["country"]=c
                anadf=anadf.append(df)
            except Exception as e:
                print(s,c,str(e))   

#     print(anadf.columns)
    anadf.to_excel(dosya,sheet_name="stocks")

    #fon
    anadf=pd.DataFrame()
    for c in investpy.get_fund_countries()[:10]: #türkiye yok
        for f in investpy.get_funds_list(country=c)[:10]:
            try:
                df = investpy.get_fund_historical_data(fund=f,country=c,from_date=bas,to_date=bts)
                df["fund"]=f
                df["country"]=c
                anadf=anadf.append(df)
            except Exception as e:
                print(f,c,str(e))            

#     print(anadf.columns)
    with pd.ExcelWriter(dosya, mode='a') as writer:
        anadf.to_excel(writer, sheet_name='funds')

    #index
    anadf=pd.DataFrame()
    for c in ["turkey"]: #investpy.get_index_countries()
        for i in investpy.get_indices_list(country=c)[:10]:
            try:
                df = investpy.get_index_historical_data(index=i,country=c,from_date=bas,to_date=bts)
                df["index"]=i
                df["country"]=c
                anadf=anadf.append(df)
            except Exception as e:
                print(i,c,str(e))            

    with pd.ExcelWriter(dosya, mode='a') as writer:
        anadf.to_excel(writer, sheet_name='index')        

    #cross currency
    anadf=pd.DataFrame()
    for cc in investpy.get_currency_crosses_list()[:10]:
        try:
            df = investpy.get_currency_cross_historical_data(currency_cross=cc,from_date=bas,to_date=bts)
            df["currency cross"]=cc
            anadf=anadf.append(df)
        except Exception as e:
            print(cc,str(e))            

    with pd.ExcelWriter(dosya, mode='a') as writer:
        anadf.to_excel(writer, sheet_name='cross currency')          

    print("işlem tamam")

except Exception as e:
    print(str(e))