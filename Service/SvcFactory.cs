﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Service
{
    public class SvcFactory
    {
            private SvcFactory() { }
            private static SvcFactory svcFactory = new SvcFactory();
            public static SvcFactory GetInstance() { return svcFactory; }

            /**
             * 
             *  return appropriate Service
             */
            public IService GetService(String service)
            {
                IService ReturnService;
             
                switch (service)
                {
                    case "AccountSvcRepoImpl":
                        ReturnService = (IService)new AccountSvcRepoImpl();
                        break;
                    case "AddressSvcRepoImpl":
                        ReturnService = (IService)new AddressSvcRepoImpl();
                        break;
                    case "CreditCardSvcRepoImpl":
                        ReturnService = (IService)new CreditCardSvcRepoImpl();
                        break;
                    case "PersonSvcRepoImpl":
                        ReturnService = (IService)new PersonSvcRepoImpl();
                        break;
                    case "TransactionSvcRepoImpl":
                        ReturnService = (IService)new TransactionSvcRepoImpl();
                        break;
                    default:
                        ReturnService = null;
                        throw new System.ArgumentException("Unimplemented Service type in SvcFactory " + ReturnService);
                        
                }

                return ReturnService;

            }           
    }
}
