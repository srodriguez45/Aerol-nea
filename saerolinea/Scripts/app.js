var app;
(function () {
    app = angular
        .module('app', [])
        .directive("preloadResource", function () {
            return {
                link: function (scope, element, attrs) {
                    scope.preloadResource = JSON.parse(attrs.preloadResource);
                    element.remove();
                }
            };
        });
})();