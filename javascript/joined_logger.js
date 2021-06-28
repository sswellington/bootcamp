'use strict';


const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
  inputString += inputStdin;
});

process.stdin.on('end', function() {
  inputString = inputString.split('\n');

  main();
});


function readLine() {
  return inputString[currentLine++];
}


const ws = fs.createWriteStream(process.env.OUTPUT_PATH);
function logger(msg) {
    ws.write(`${msg.text}\n`);
}


function joinedLogger(level, sep) {
    //https://stackoverflow.com/questions/62518241/how-to-loop-with-curry-function
    return function(arr){
        console.log('level',level);
        console.log('sep',sep);
        console.log('arr',arr);
        //console.log(arr[0].text+';'+arr[1].text+';'+arr[3].text);
    }
}


function main() {
    const firstLine = ['21', ';'];
    const level = '2';
    const sep = firstLine[1];
    const myLog = joinedLogger(level, sep);
    const n = 4;
    let messages = [];
    var ob = {level: 20, text: 'foo'};
    messages.push(ob);
    ob = {level: 90, text: 'bar'};
    messages.push(ob);
    console.log(messages);
    myLog(...messages);
}
