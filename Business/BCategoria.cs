using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace Business
{
    public class BCategoria
    {
        private DCategoria dCategoria = null;

        public List<Categoria> Listar(int IdCategoria)
        {
            List<Categoria> categorias = null;
            try
            {
                dCategoria = new DCategoria();
                categorias = dCategoria.Listar(new Categoria { IdCategoria = IdCategoria });
            }
            catch(Exception e)
            {
                throw e;
            }
            return categorias;
        }

        public bool Insertar(Categoria categoria)
        {
            bool result = true;
            try
            {
                dCategoria = new DCategoria();
                int ultimoId= dCategoria.ObtenerUltimoId();
                if (ultimoId != -1)
                {
                    categoria.IdCategoria = ultimoId;
                    dCategoria.Insertar(categoria);
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                result = false;
            }
            return result;
        }

        public bool Actualizar(Categoria categoria)
        {
            bool result = true;
            try
            {
                dCategoria = new DCategoria();
                dCategoria.Actualizar(categoria);
            }
            catch (Exception e)
            {
                result = false;
            }
            return result;
        }

        public bool Eliminar(int IdCategoria)
        {
            bool result = true;
            try
            {
                dCategoria = new DCategoria();
                dCategoria.Eliminar(IdCategoria);
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}
