/// <reference path="angular.js" />

app.controller('loginController', function ($scope) {

    $scope.onLogIn = function () {
        alert('User has Clicked on LogIn Button');
        alert(JSON.stringify($scope.loginInfo));
    };

});

app.controller('registrationController', function ($scope) {
    $scope.onRegister = function () {
        alert('User has Clicked on Register Button');
        alert(JSON.stringify($scope.userInfo));
    };
});

app.controller('contactUsController', function ($scope) {

});