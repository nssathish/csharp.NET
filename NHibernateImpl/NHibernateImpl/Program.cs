using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace NHibernateImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            var cfg = new Configuration();
            String _dataSource ="Data Source = ICOSWK0033\\SQLEXPRESS";
            String _initialCatalog = "Initial Catalog = NHibernateImplDB";
            String _integratedSecurity = "Integrated Security = true";
            String _timeout = "Connect Timeout = 15";
            String _encrypt = "Encrypt = False";
            String _certificate = "TrustServerCertificate = False";
            String _applicationIntent = "ApplicationIntent = ReadWrite";
            String _subnetFailover = "MultiSubnetFailover = False";

            cfg.DataBaseIntegration(x =>
            {
                //x.ConnectionString = "Data Source + Initial Catalog + Integrated Security + Connect Timeout + Encrypt + TrustServerCertificate + ApplicationIntent + MultiSubnetFailover";
                x.ConnectionString = _dataSource + _initialCatalog + _integratedSecurity + _timeout + _encrypt + _certificate + _applicationIntent + _subnetFailover; 
                x.Driver<SqlClientDriver>();
                x.Dialect<MsSql2012Dialect>();
            });

            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sefact = cfg.BuildSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    //perform database logic
                    tx.Commit();
                }
                Console.ReadLine();
            }
        }
    }
}
