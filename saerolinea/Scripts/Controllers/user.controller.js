/*
 * Controlador
 */
app.controller('userController', ['$scope', 'userService', function ($scope, userService) {

    //iniciamos un post cualquiera como un objeto vacÃ­o
    $scope.list = {};

    function init() {

        userService.List()
            .then(response => response.data)
            .then(function (data) {
                if (data != null) {
                    console.log(data);
                    $scope.list = data;
                }
            });

    }


    init();

}]);