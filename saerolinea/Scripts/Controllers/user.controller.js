(function () {
    init();
})();

function init() {
    app.controller('userController', userController);
    userController.$inject = ['$scope', '$http', 'userService', '$filter', 'repoService'];

    function userController($scope, $http, userService, $filter) {

        $scope.list = {};

        $scope.List = () => {
            userService.List()
                .then(response => response.data)
                .then(function (data) {
                    if (data != null) {
                        $scope.list = data.list;
                    }
                });
        }
        //Init
        $scope.Init = () => {
            $scope.List();
        }

        $scope.Init();
    }
}