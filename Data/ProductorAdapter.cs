using Entidades;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductorAdapter: Adapter
    {
        
        public void AltaProductor(Productor p)
        {
            try
            {
                Con.Open();
                OleDbCommand comando = new OleDbCommand("INSERT INTO productores(cuitProductor, nombreApellido, passwordd)  VALUES(@c, @na, @pw);", Con);
                comando.Parameters.AddWithValue("@identificacion", p.CuitProductor);
                comando.Parameters.AddWithValue("@tipoIdentificacion", p.NombreApellido);
                comando.Parameters.AddWithValue("@nombre", p.Password);
                comando.ExecuteNonQuery();
            }
            catch (System.Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Ya existe esa cuit", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Con.Close();
            }   
        }

        public void ModificarProductor(Productor productor, string cuit)
        {
            try
            {
                Con.Open();
                OleDbCommand comando = new OleDbCommand("UPDATE productores SET cuitProductor=@cuit, nombreApellido=@nameAndApe, passwordd=@pw  WHERE cuitProductor='" + cuit + "'", Con);
                comando.Parameters.AddWithValue("@cuit", productor.CuitProductor);
                comando.Parameters.AddWithValue("@nameAndApe", productor.NombreApellido);
                comando.Parameters.AddWithValue("@pw", productor.Password);
                comando.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar productor", ex);
                throw ExcepcionManejada;
            }
            finally
            {
               Con.Close();
            }
        }

        public Productor GetOne(string cuit)
        {
            Productor p;
            try
            {
                Con.Open();
                OleDbCommand comando = new OleDbCommand("SELECT * FROM productores WHERE cuitProductor=@cuit", Con);
                comando.Parameters.AddWithValue("@cuit", cuit);
                OleDbDataReader dr = comando.ExecuteReader();
                p = new Productor();
                if (dr.Read())
                {
                    p.CuitProductor = (string)dr["cuitProductor"];
                    p.NombreApellido = (string)dr["nombreApellido"];
                    p.NombreApellido = (string)dr["nombreApellido"];
                    p.Password = (string)dr["passwordd"];
                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar productor", ex);
                throw ExcepcionManejada;

            }
            finally
            {
                Con.Close();
            }
            return p;
        }

        public List<Productor> GetAll()
        {
            List<Productor> ListaProductores = new List<Productor>();
            Productor p;
            try
            {
                Con.Open();
                OleDbCommand comando = new OleDbCommand("SELECT * FROM productores", Con);
                OleDbDataReader dr = comando.ExecuteReader();
                while(dr.Read())
                {
                    p = new Productor();
                    p.CuitProductor = (string)dr["cuitProductor"];
                    p.NombreApellido = (string)dr["nombreApellido"];
                    p.Password = (string)dr["passwordd"];
                    ListaProductores.Add(p);
                }                
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Ocurrio un error al recuperar productores", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Con.Close();
            }
            return ListaProductores;
        }
    } 
}
