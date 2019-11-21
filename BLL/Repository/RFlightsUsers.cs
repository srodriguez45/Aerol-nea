using BLL.Model;
using DALL;
using DALL.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class RFlightsUsers : AppModel
    {


        public int Add(ModelFlightsUsers obj)
        {
            int id = 0;

            try
            {
                using (db)
                {

                    db.flightsUsers.Add(map(obj));
                    db.SaveChanges();
                    var model = getBy(obj.documentNumber, obj.idFlight);
                    id = model.idFlightUser;

                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error " + e);
            }

            return id;

        }


        public List<ModelFlightsUsers> Add(List<ModelFlightsUsers> list)
        {
            List<ModelFlightsUsers> listVinc = new List<ModelFlightsUsers>();

            try
            {
                using (var db1 = new AerolineaContext())
                {
                    foreach (var obj in list)
                    {
                        db1.flightsUsers.Add(map(obj));
                        db1.SaveChanges();
                        var model = getBy(obj.documentNumber, obj.idFlight);
                        listVinc.Add(model);
                    }

                    

                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error " + e);
            }

            return listVinc;

        }


        public ModelFlightsUsers getBy(int document, int idFlight)
        {

            try
            {

                using (var db1 = new AerolineaContext())
                {

                    var model = map(
                        db1.flightsUsers.Where(
                            fu => fu.documentNumber.Equals(document) && fu.idFlight.Equals(idFlight)
                        ).First()
                    );

                    return model;

                }

            }
            catch (Exception) { return new ModelFlightsUsers(); }


        }


        public ModelFlightsUsers get(int id)
        {

            try
            {

                using (db)
                {

                    return map(
                        db.flightsUsers.Find(id)
                    );

                }

            }
            catch (Exception) { return new ModelFlightsUsers(); }


        }


        public List<ModelFlightsUsers> findAll()
        {

            using (db)
            {

                return db.flightsUsers.Select(map).ToList();
                

            }


        }


        //es una forma de castear un objeto con otro para usar ModelFlights
        private flightsUsers map(ModelFlightsUsers obj)
        {

            return new flightsUsers()
            {
                idFlight = obj.idFlight,
                documentNumber = obj.documentNumber,
                idFlightUser = obj.idFlightUser
            };

        }


        //es una forma de castear un objeto con otro para usar ModelFlights
        private ModelFlightsUsers map(flightsUsers obj)
        {

            return new ModelFlightsUsers()
            {
                idFlight = obj.idFlight,
                documentNumber = obj.documentNumber,
                idFlightUser = obj.idFlightUser
            };

        }


    }
}
