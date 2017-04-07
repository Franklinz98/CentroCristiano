using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CentroCristiano
{
    
    class Pastores
    {
        
        class Pastor
        {
            public String nombre;
            public String cargo;
            public long id;
            public int pass;
            public Pastor link;
        }

        static Pastor ptrpastores;

        Pastor AgregarPastores(Pastor ptr, String nombre, String cargo, long id, int pass)
        {
            Pastor p = new Pastor();
            p.nombre = nombre;
            p.cargo = cargo;
            p.id = id;
            p.pass = pass;
            if (ptr == null)
            {
                ptr = p;
            }
            else
            {
                Pastor q = ptr;
                while (q.link!=null)
                {
                    q = q.link;
                }
                q.link = p;
            }
            return ptr;
        }
        void CargarPastor(String URL)
        {
            string linea;
            /*TextReader pastores;
            pastores = new StreamReader("..\\..\\Resources\\inscriptos.txt");*/
            System.IO.StreamReader file =
            new System.IO.StreamReader("..\\..\\Resources\\" + URL);
            while ((linea = file.ReadLine()) != null)
            {
                String[] info = linea.Split(';');
                ptrpastores = AgregarPastores(ptrpastores,info[0],info[1],long.Parse(info[2]),int.Parse(info[3]));
                //System.Console.WriteLine(linea);
            }
        }
        public static bool buscarPastor(long id, int clave)
        {
            Pastor p = ptrpastores;
            while ((p.id != id && p.pass != clave) && p.link != null)
            {
                p = p.link;
            }
            if (p.id == id && p.pass == clave)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Pastores()
        {
            ptrpastores = null;
            CargarPastor("Pastores.txt");
        }
    }
}
