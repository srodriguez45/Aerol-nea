app.service('aeroService', function ($http, $q) {
    this.GetUsers = function () {
        return $http.get('/api/Users/')
    }

    this.GetFlights = function () {
        return $http.get('/api/Flights/')
    }

    this.users =
        [{ idUser: 5, userName: "Laura Rodriguez Rico", documentType: "CC ", documentNumber: 1000111457, email: "laurh@gmail.com" }, 
                { idUser: 7, userName: "Julieth Pinto", documentType: "CC ", documentNumber: 1000754748, email: "julieth@gmail.com" },
                { idUser: 2, userName: "Jair Rodriguez", documentType: "CC ", documentNumber: 1016034447, email: "jair@gmail.com" },
                { idUser: 1, userName: "Steven Rodriguez", documentType: "CC ", documentNumber: 1016034544, email: "steven@gmail.com" },
                { idUser: 4, userName: "Maria Sierra", documentType: "CC ", documentNumber: 1016664445, email: "luzm@gmail.com" },
                { idUser: 3, userName: "Jaime Rivera", documentType: "CC ", documentNumber: 1016754745, email: "jaimer@gmail.com" },
                { idUser: 6, userName: "Katerine Rodriguez", documentType: "CC ", documentNumber: 1019022241, email: "kte@gmail.com" }];

    this.flights = 
        [{ idFlight: 1, citySource: "BOG", cityDestination: "MTR", departureDateTime: "2018-10-30T00:00:00", planeNumber: "001", pilotName : "Stifler Master"},
        { idFlight: 2, citySource: "CTG", cityDestination: "BOG", departureDateTime: "2018-10-30T10:00:00", planeNumber: "002", pilotName : "Will Ferrell"},
        { idFlight: 3, citySource: "BGA", cityDestination: "BOG", departureDateTime: "2018-10-31T00:00:00", planeNumber: "003", pilotName : "Jhon Doe"},
        { idFlight: 4, citySource: "BGA", cityDestination: "BOG", departureDateTime: "2018-10-31T00:00:00", planeNumber: "003", pilotName : "Daniel Foo"},
        { idFlight: 5, citySource: "CUC", cityDestination: "MDE", departureDateTime: "2018-10-31T12:00:00", planeNumber: "004", pilotName : "Ning Shu"}];
    
});