using JulekalenderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JulekalenderAPI
{
    public class DbInitializer
    {
        public static void Initialize(LågeContext context)
        {
            context.Database.EnsureCreated();
            Låge[] låger = new Låge[24];

            if (!context.Låger.Any())
            {
                låger = new Låge[]
                {
                    new Låge{Dag=1, EksamensEmne=""},
                    new Låge{Dag=2, EksamensEmne=""},
                    new Låge{Dag=3, EksamensEmne=""},
                    new Låge{Dag=4, EksamensEmne=""},
                    new Låge{Dag=5, EksamensEmne=""},
                    new Låge{Dag=6, EksamensEmne=""},
                    new Låge{Dag=7, EksamensEmne=""},
                    new Låge{Dag=8, EksamensEmne=""},
                    new Låge{Dag=9, EksamensEmne=""},
                    new Låge{Dag=10, EksamensEmne=""},
                    new Låge{Dag=11, EksamensEmne=""},
                    new Låge{Dag=12, EksamensEmne=""},
                    new Låge{Dag=13, EksamensEmne=""},
                    new Låge{Dag=14, EksamensEmne=""},
                    new Låge{Dag=15, EksamensEmne=""},
                    new Låge{Dag=16, EksamensEmne=""},
                    new Låge{Dag=17, EksamensEmne=""},
                    new Låge{Dag=18, EksamensEmne=""},
                    new Låge{Dag=19, EksamensEmne=""},
                    new Låge{Dag=20, EksamensEmne=""},
                    new Låge{Dag=21, EksamensEmne=""},
                    new Låge{Dag=22, EksamensEmne=""},
                    new Låge{Dag=23, EksamensEmne=""},
                    new Låge{Dag=24, EksamensEmne=""}

                };

                foreach (Låge låge in låger)
                {
                    context.Låger.Add(låge);
                }
                context.SaveChanges();
            }
        }
    }
}
