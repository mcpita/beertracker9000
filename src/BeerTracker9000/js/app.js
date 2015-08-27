angular.module("beerTracker", []);
var app = angular.module("beerTracker");
app.run(function (){
    
});


app.controller("AddBeerCtrl", ["$scope", function ($scope) {
    $scope.add = function () {
        $scope.name = "";
        $scope.saved = true;
    };

}]);