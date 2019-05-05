import angular from "angular";


const windows95: any = angular.module("windows95", []);
windows95.controller("navigation", [
    "$scope", ($scope: any) => {
        $scope.isOptions = false;
        $scope.toggleOptions = () => {
            $scope.isOptions = !$scope.isOptions;
            console.log("Potato");
        }
    }
]);
