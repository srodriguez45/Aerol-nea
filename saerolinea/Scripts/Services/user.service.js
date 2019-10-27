app.service('userService', function ($http, $q) {
    this.BasicInfo = function () {
        return $http.get('/Users/Get')
    }
});