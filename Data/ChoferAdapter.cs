using Entidades;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ChoferAdapter : Adapter
    {
        public List<Chofer> GetAll()
        {
            List<Chofer> listaChoferes = new List<Chofer>();
            Chofer c;
            try
            {
                Con.Open();
                OleDbCommand comando = new OleDbCommand("SELECT * FROM camioneros", Con);
                OleDbDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    c = new Chofer();
                    c.Id = (int)dr["Id"];
                    c.CuitChofer = (string)dr["cuitChofer"];
                    c.CuitIntermediario = (string)dr["cuitIntermediario"];
                    c.CuitTransportista = (string)dr["cuitTransportista"];
                    c.NombreApellidoChofer = (string)dr["nombreApellidoChofer"];
                    c.NombreApellidoIntermediario = (string)dr["nombreApellidoIntermediario"];
                    c.NombreApellidoTransportista = (string)dr["nombreApellidoTransportista"];
                    c.PatenteAcoplado1 = (string)dr["patenteAcoplado1"];
                    c.PatenteAcoplado2 = (string)dr["patenteAcoplado2"];
                    c.PatenteChasis = (string)dr["patenteChasis"];
                    listaChoferes.Add(c);
                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Problemas al recuperar los choferes", ex);
                throw ExcepcionManejada;
            }
            finally
            {
              Con.Close();
            }
            return listaChoferes; 
        }

        public void ModificarChofer(Chofer chofer, int id)
        {
            try
            {
                Con.Open();
                OleDbCommand comando = new OleDbCommand("UPDATE camioneros SET cuitChofer=@cc, nombreApellidoChofer=@nac, " +
                    "cuitTransportista=@ct, nombreApellidoTransportista=@nat, cuitIntermediario=@ci, nombreApellidoIntermediario=@nai, " +
                    "patenteChasis=@pc, patenteAcoplado1=@pac1, patenteAcoplado2=@pac2  WHERE Id= @id", Con);             
                comando.Parameters.AddWithValue("@cc", chofer.CuitChofer);
                comando.Parameters.AddWithValue("@nac", chofer.NombreApellidoChofer);
                comando.Parameters.AddWithValue("@ct", chofer.CuitTransportista);
                comando.Parameters.AddWithValue("@nat", chofer.NombreApellidoTransportista);
                comando.Parameters.AddWithValue("@ci", chofer.CuitIntermediario);
                comando.Parameters.AddWithValue("@nai", chofer.NombreApellidoIntermediario);
                comando.Parameters.AddWithValue("@pc", chofer.PatenteChasis);
                comando.Parameters.AddWithValue("pac1", chofer.PatenteAcoplado1);
                comando.Parameters.AddWithValue("pac2", chofer.PatenteAcoplado2);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar chofer", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Con.Close();
            }
        }

        public Chofer GetOne(int id)
        {
            Chofer c;
            try
            {
                Con.Open();
                OleDbCommand comando = new OleDbCommand("SELECT * FROM camioneros WHERE Id=@id", Con);
                comando.Parameters.AddWithValue("@id", id);
                OleDbDataReader dr = comando.ExecuteReader();
                c = new Chofer();
                if (dr.Read())
                {
                    c.Id = (int)dr["Id"];
                    c.CuitChofer = (string)dr["cuitChofer"];
                    c.NombreApellidoChofer = (string)dr["nombreApellidoChofer"];
                    c.CuitTransportista = (string)dr["cuitTransportista"];
                    c.NombreApellidoTransportista = (string)dr["nombreApellidoTransportista"];
                    c.CuitIntermediario = (string)dr["cuitIntermediario"];
                    c.NombreApellidoIntermediario = (string)dr["nombreApellidoIntermediario"];
                    c.PatenteChasis = (string)dr["patenteChasis"];
                    c.PatenteAcoplado1 = (string)dr["patenteAcoplado1"];
                    c.PatenteAcoplado2 = (string)dr["patenteAcoplado2"];
                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar Chofer", ex);
                throw ExcepcionManejada;

            }
            finally
            {
                Con.Close();
            }
            return c;
        }

        public void AltaChofer(Chofer c)
        {
            try
            {
                Con.Open();
                OleDbCommand comando = new OleDbCommand("INSERT INTO camioneros(cuitChofer, nombreApellidoChofer, nombreApellidoTransportista, cuitTransportista, cuitIntermediario, nombreApellidoIntermediario, patenteChasis, patenteAcoplado1, patenteAcoplado2)  " +
                                                        "VALUES(@cuitChofer, @nombreApellidoChofer, @nombreApellidoTransportista, @cuitTransportista, @cuitIntermediario, @nombreApellidoIntermediario, @patenteChasis, @patenteAcoplado1, @patenteAcoplado2);", Con);
                comando.Parameters.AddWithValue("@cuitChofer", c.CuitChofer);
                comando.Parameters.AddWithValue("@nombreApellidoChofer", c.NombreApellidoChofer);
                comando.Parameters.AddWithValue("@nombreApellidoTransportista", c.NombreApellidoTransportista);
                comando.Parameters.AddWithValue("@cuitTransportista", c.CuitTransportista);
                comando.Parameters.AddWithValue("@cuitIntermediario", c.CuitIntermediario);
                comando.Parameters.AddWithValue("@nombreApellidoIntermediario", c.NombreApellidoIntermediario);
                comando.Parameters.AddWithValue("@patenteChasis", c.PatenteChasis);
                comando.Parameters.AddWithValue("@patenteAcoplado1", c.PatenteAcoplado1);
                comando.Parameters.AddWithValue("@patenteAcoplado2", c.PatenteAcoplado2);
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
    }
}
 