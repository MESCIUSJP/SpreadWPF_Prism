﻿using System;
using System.Data;

namespace SpreadWPF_Prism
{
    public class ProductModel
    {
        private static DataSet ds;

        public ProductModel() { }

        public static DataTable GetProducts()
        {
            if (ds == null)
            {
                ds = new DataSet();
                DataTable dt = ds.Tables.Add("Product");
                dt.Columns.Add("Code", typeof(String));
                dt.Columns.Add("Name", typeof(String));
                dt.Columns.Add("Price", typeof(Int32));
                dt.Rows.Add("0000001", "アーモンド", 200);
                dt.Rows.Add("0000002", "グレープシード", 200);
                dt.Rows.Add("0000003", "オリーブ", 320);
                dt.Rows.Add("0000004", "ゴマ油", 300);
                dt.Rows.Add("0000005", "ひまわり", 200);
                dt.Rows.Add("0000006", "えごま", 300);
                dt.Rows.Add("0000007", "アルガン", 800);
                dt.Rows.Add("0000008", "ココナッツ", 720);
                dt.Rows.Add("0000009", "ウォールナッツ", 400);
                dt.Rows.Add("0000010", "亜麻仁油", 700);
                ds.AcceptChanges();
            }
            return ds.Tables["Product"];
        }
    }
}
