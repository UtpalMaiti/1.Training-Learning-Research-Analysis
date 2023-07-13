/// <reference path="angular.js" />

var app = angular.module('demoApp', []);

app.service('employeeService', function ($http,$q) {

    this.getAll = function () {

        var promiseObject = $q.defer();

        $http.get('http://localhost:2212/api/EmployeeApi').then(function (list) {
            
            promiseObject.resolve(list.data);

        });

        return promiseObject.promise;
    };

});

app.controller('demoController', function ($scope,employeeService) {

    $scope.empList = [];

    employeeService.getAll().then(function (result) {
        $scope.empList = result;
    });

});