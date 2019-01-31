using Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PrinterRepository : BaseRepository<Printer, int>, IPrinterRepository

    {
        protected virtual string GetAllPrintersStoredProcedureName => $"mg_{EntityName}_GetAll";
        protected virtual string AddPrinterStoredProcedureName => $"mg_{EntityName}_Add";
        protected virtual string DeletePrinterStoredProcedureName => $"mg_{EntityName}_DeleteById";
        protected virtual string UpdatePrinterStoredProcedureName => $"mg_{EntityName}_UpdateById";
        public PrinterRepository(IDatabaseProviderFactory factory) : base(factory)
        {
        }

        public List<Printer> GetAll()
        {
            using (var command = Db.GetStoredProcCommand(GetAllPrintersStoredProcedureName))
            {
                return LoadPrinters(command);
            }
        }

        public List<Printer> LoadPrinters(DbCommand command)
            {
                var printers = new List<Printer>();

                using (var objDataReader = Db.ExecuteReader(command))
                {
                    while (objDataReader.Read())
                    {
                        var printer = Printer.MapTo(objDataReader);

                        printers.Add(printer);
                    }

                }
                return printers;
            }

        public void AddPrinter(string serial, string mark, int model, int copiesCounter)
        {
            var command = Db.GetStoredProcCommand(AddPrinterStoredProcedureName);
            Db.AddInParameter(command, "@serial", System.Data.DbType.String, serial);
            Db.AddInParameter(command, "@mark", System.Data.DbType.String, mark);
            Db.AddInParameter(command, "@model", System.Data.DbType.Int32, model);
            Db.AddInParameter(command, "@copiesCounter", System.Data.DbType.Int32, copiesCounter);
            Db.ExecuteScalar(command);
        }

        public void DeletePrinter(int id)
        {
            var command = Db.GetStoredProcCommand(DeletePrinterStoredProcedureName);
            Db.AddInParameter(command, "@Id", System.Data.DbType.String, id);
            Db.ExecuteNonQuery(command);
        }

        public void UpdatePrinter(int id, string serial, string mark, int model, int copiesCounter)
        {
            var command = Db.GetStoredProcCommand(UpdatePrinterStoredProcedureName);
            Db.AddInParameter(command, "@Id", System.Data.DbType.String, id);
            Db.AddInParameter(command, "@serial", System.Data.DbType.String, serial);
            Db.AddInParameter(command, "@mark", System.Data.DbType.String, mark);
            Db.AddInParameter(command, "@model", System.Data.DbType.Int32, model);
            Db.AddInParameter(command, "@copiesCounter", System.Data.DbType.Int32, copiesCounter);
            Db.ExecuteNonQuery(command);
        }
    }
    }

