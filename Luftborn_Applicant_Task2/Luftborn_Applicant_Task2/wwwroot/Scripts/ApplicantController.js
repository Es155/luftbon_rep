

var app = angular.module("Applicant", []);
app.controller("ApplicantController", function ($scope, $http) {
    $scope.btntext = "Save";
    // Add record
    $scope.savedata = function () {
        $scope.btntext = "Please Wait..";
        alert(true);
        $http({
            method: 'POST',
            url: '/Applicant/AddApplicant',
            data: {"id": 2},
            datatype: "json",
        }).then(function (d) {

            $scope.btntext = "Save";

          

            alert(d);

        },function (error){

           

        });

    };
})