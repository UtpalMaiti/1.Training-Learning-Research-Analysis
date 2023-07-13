/// <reference path="angular.js" />

var app = angular.module('testpp', ['ngRoute']);

app.config(['$routeProvider', function ($routeProvider) {

    $routeProvider.when('/login', {
        templateUrl: 'Pages/login.html',
        controller: 'loginController'
    }).when('/register', {
        templateUrl: 'Pages/registration.html',
        controller: 'registrationController'
    }).when('/contact', {
        templateUrl: 'Pages/contactUs.html',
        controller: 'contactUsController'
    }).otherwise({
        redirectTo:'login'
    });

}]);