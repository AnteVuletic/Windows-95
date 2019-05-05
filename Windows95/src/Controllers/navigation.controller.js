import angular from "angular";
var windows95 = angular.module("windows95", []);
windows95.controller("navigation", [
    "$scope", function ($scope) {
        $scope.isOptions = false;
        $scope.toggleOptions = function () {
            $scope.isOptions = !$scope.isOptions;
            console.log("Potato");
        };
    }
]);
//# sourceMappingURL=navigation.controller.js.map