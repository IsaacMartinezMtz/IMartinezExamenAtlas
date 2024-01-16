using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Productos
    {
        public static bool AddProductos(ML.Productos productos)
        {
            bool result = false;
            try
            {
                using(DL.MercanciasEntities context = new DL.MercanciasEntities())
                {
                    var query = context.ProductosAdd(productos.Nombre, productos.Tipo.IdTipo, productos.Precio);
                    if(query > 0) 
                    { 
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }

            }catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
