'use strict';

REMApp.controller('NavbarController', ['$scope', '$window', '$http', 'API',
    function ($scope, $window, $http, API) {

        API.getAllUsers().then(function (data) {
            $scope.propGovdes = data;
        });

    }
]);