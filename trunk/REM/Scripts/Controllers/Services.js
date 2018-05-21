'use strict';

REMApp.factory('API', function ($http) {
    var _localStorageData = {};
    return {
        getAllUsers: function () {
            return $http.get('/api/REMAPI/getAllUsers')
            .then(function (response) {
                return response.data;
            });
        }
    };
});
