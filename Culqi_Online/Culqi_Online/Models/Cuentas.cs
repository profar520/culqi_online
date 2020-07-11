using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Cuenta
    {
        public static int RegistrarCuenta(Cuentadto cuentadto)
        {
            bd_culqiEntities db = new bd_culqiEntities();
            Cuenta cuenta= new Cuenta();
            cuenta.ID_Banco = cuentadto.ID_Banco;
            cuenta.ID_Usuario = cuentadto.ID_Usuario;
            cuenta.ID_Tipo_Cuenta = cuentadto.ID_Tipo_Cuenta;
            cuenta.ID_Moneda = cuentadto.ID_Moneda;
            cuenta.ID_Lugar = cuentadto.ID_Lugar;
            cuenta.Numero_Cuenta = cuentadto.Numero_Cuenta;
            db.Cuenta.Add(cuenta);
            try
            {
                return db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }
    }
}