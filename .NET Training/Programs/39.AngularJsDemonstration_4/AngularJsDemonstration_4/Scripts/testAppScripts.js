/// <reference path="angular.js" />
var app = angular.module('testApp', []);

app.controller('demoController', function ($scope) {

});

app.directive('testDirective', function () {
    return {
        restrict: 'EACM',
        scope:{
            linkUrl: '@',
            linkText:'@'
        },
        template: '<a href="{{linkUrl}}">{{linkText}}</a>',
        link: function ($scope, element, attrs) {
            element.bind('mouseenter', function () {
                element.css('background-color', 'red');
            });

            element.bind('mouseleave', function () {
                element.css('background-color', 'white');
            });
        }
    };
});

app.directive('loginDirectiveNew', function () {
    return {
        restrict:'E',
        templateUrl: 'login.html',
        controller:'loginController'
    };
});

app.controller('loginController',function($scope){
    $scope.onLogIn=function(){
        alert(JSON.stringify($scope.loginInfo));
    };
});

