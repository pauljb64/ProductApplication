var productListApp = angular.module("productListApp",  ["ngRoute"]);

productListApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/', {
        templateUrl: "/app/views/productsCatalogView.html",
        controller: "productsCatalogController"
    });
       
}]);

productListApp.controller('productsCatalogController', 
    function ($scope, $http, productService) {

        $scope.prods = {};
         $scope.prods.basket = {};
        $scope.prods.basket = { products: [] };
        $scope.prods.basket.totalAmount = 0.00;
        $scope.rawdata = {};
        $scope.prodCat = {};
        var productCat = { products: [] };
        $scope.prodCat = productService.getallProducts(productCat);
        console.log($scope.rawdata);
        console.log($scope.prodCat);
        console.log(productCat);
        $scope.prods.products = productCat.products;
        //console.log(productCat.$$state.value);
        var prodCnt = 0;
      
        $scope.addProductBasket = function (product) {
            console.log(product);
            console.log($scope.prods);
            var productBacketItem = { Name: product.Name, Quantity: 0, ProductCode: product.ProductCode, Price: product.Price }
            $scope.prods.basket.products.push(productBacketItem);
            $scope.prods.basket.totalAmount += product.Price;
        }

       $scope.postCheckout = function (basket) {
                        $http({
                            method: "Post",
                            url: "http://localhost:1102/api/basket",
                            data: basket
                        });
        }
});

productListApp.factory('productService', function ($http) {
    return {
        getallProducts: function (productCat) {
            return $http({
                method: "GET",
                url: "http://localhost:1102/api/Products",
                headers: { 'Content-Type': 'application/json' }
            }).success(function (data) {
                console.log(data);
                for (var ProductCategory in data) {
                    console.log(data[ProductCategory]);
                    var productsCat = data[ProductCategory];
                    for (var productIndex in productsCat.Products) {
                        console.log("Cats",productsCat.Products);
                        var nProduct = productsCat.Products[productIndex];
                        console.log("nProduct",nProduct);
                        var product = { Name: nProduct.Name, Price: nProduct.UnitPrice, ProductCode: nProduct.ProductCode };
                        console.log("product",product);
                         productCat.products.push(product);
                    }
                }
                console.log(productCat);
            }).error(function (data)
            {
                console.log(data);
            });;
        }
    }
});

