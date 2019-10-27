app.service('userService', function ($http, $q) {
    this.List = function () {
        return $http.get('/api/Users/')
    }
});