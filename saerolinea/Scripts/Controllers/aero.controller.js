/*
 * Controlador
 */
app.controller('aeroController', ['$scope', 'aeroService', function ($scope, aeroService) {

    //Objects
    $scope.flights = [];
    $scope.users = [];

    function init()
    {
        //Users
        aeroService.GetUsers()
            .then(response => response.data)
            .then(function (data) {
                if (data != null) {
                    $scope.users = data;
                } 
            });

        if ($scope.users.length == 0) {
            $scope.users = aeroService.users;
        } 
        
        //Flights
        aeroService.GetFlights()
            .then(response => response.data)
            .then(function (data) {
                if (data != null) {
                    $scope.flights = data;
                    console.log($scope.flights);
                }
            });

        if ($scope.flights.length == 0) {
            $scope.flights = aeroService.flights;
        } 
    }

    init();

}]);