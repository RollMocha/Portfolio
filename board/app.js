const fs = require("fs");
const ejs = require("ejs");
const mysql = require("mysql");
const express = require("express");
const bodyParser = require("body-parser");

const client = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: '1111',
    database: 'aws'
});

const app = express();
app.use(bodyParser.urlencoded({extended: false}));

//get("/"): list
//get("/insert"): 값을 넣는 페이지 표시
//post("/insert"): 값을 DB에 넣음
//get("/edit/:id"): 수정하는 페이지 표시
//post("/edit/:id"): DB 수정
//get("/delete/:id"): 삭제

app.listen(8888,function(){
    console.log("run at 8888");
});

app.get("/",function(req,res){
    fs.readFile("main.html","utf8",function(error,data){
        client.query('select * from board', function(error, result){
            res.send(ejs.render(data, {result: result}));
        });
    });
});

app.get("/add", function(req, res) {
    fs.readFile("add.html", "utf8", function(err, data) {
        res.send(data);
    });
});