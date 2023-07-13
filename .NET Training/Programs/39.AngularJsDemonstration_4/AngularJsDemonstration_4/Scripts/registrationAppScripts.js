/// <reference path="angular.js" />
var app = angular.module('registrationApp', []);

app.value('errorMessage', {
    'FirstName': 'Please Enter First Name',
    'UserName': 'Please Enter UserName',
    'UserNameMin': 'UserName should be of minimum 8 Characters'
});

app.controller('registrationController', function ($scope,errorMessage) {

    $scope.messages = errorMessage;

    $scope.isLastNameRequired = true;

    $scope.onSubmit = function () {
        alert(JSON.stringify($scope.userInfo));
    };

});