//example:  http server
// var http = require('http');
// http.createServer(function(req, res){
//     res.writeHead(200, {'Content-Type': 'text/html'});
//     res.write('<h1>Nodejs</h1>');
//     res.end('<p>fuck wolrd</p>');
// }).listen(3000);
// console.log("fuck");

//example:  read file with block
// var fs = require('fs');
// fs.readFile('test', 'utf-8', function(err, data){
//     if(err){
//         console.error(err);
//     }else{
//         console.log(data);
//     }
// });
// console.log("nani");

//use module
// var myModule = require('./module');
// m1 = new myModule();
// m2 = new myModule();
// m1.setName("1");
// m2.setName("2");
// m1.sayHello();
// m2.sayHello();

//get package
var sompackage = require('./package');
sompackage.hello();