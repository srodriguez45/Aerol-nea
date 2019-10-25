using BLL.Model;
using DALL.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class RFlights : AppModel
    {


        public int add(ModelFlights obj)
        {
            int id = 0;

            try
            {
                using (db)
                {

                    db.flights.Add(map(obj));
                    db.SaveChanges();
                    var model = getByPlaneNumber(obj.planeNumber);
                    id = model.idFlight;

                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error " + e);
            }

            return id;

        }

        public List<ModelFlights> findAll()
        {

            using (db)
            {

                return db.flights.Select(map).ToList();

            }


        }


        public ModelFlights get(int number)
        {

            try
            {

                using (db)
                {

                    return map(db.flights.Find(number));

                }

            }
            catch (Exception e) { return new ModelFlights(); }


        }


        public ModelFlights getByPlaneNumber(string number)
        {

            try
            {

                using (db)
                {

                    return map(
                        db.flights.Where(
                            f => f.planeNumber.Equals(number)
                        ).First()
                    );

                }

            }
            catch (Exception e) { return new ModelFlights(); }


        }



        //es una forma de castear un objeto con otro para usar ModelFlights
        private flights map(ModelFlights obj)
        {

            return new flights()
            {
                idFlight = obj.idFlight,
                citySource = obj.citySource,
                cityDestination = obj.cityDestination,
                pilotName = obj.pilotName,
                planeNumber = obj.planeNumber,
                departureDateTime = obj.departureDateTime
            };

        }


        //es una forma de castear un objeto con otro para usar ModelFlights
        private ModelFlights map(flights obj)
        {

            return new ModelFlights()
            {
                idFlight = obj.idFlight,
                citySource = obj.citySource,
                cityDestination = obj.cityDestination,
                pilotName = obj.pilotName,
                planeNumber = obj.planeNumber,
                departureDateTime = obj.departureDateTime
            };

        }


    }
}
