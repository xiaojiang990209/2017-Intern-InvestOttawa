const got = require('got');
const jsdom = require("jsdom");
const fs = require("fs");
var streamify = require('stream-array');

var dataArray = [];
var url = process.argv[2];

new Promise(function (resolve, reject) {
    got(url)
        .then(response => {
            jsdom.env(response.body, ["http://code.jquery.com/jquery.js"], (error, window) => {
                const test = window.$('span.lastUnit.align-right').get(0);
                const totalMembers = window.$(test).text();
                resolve(totalMembers);

            });
        })
        .catch(error => {
            console.log(error.response.body);
            reject(error);
        });
})
    .then(totalMembers => {
        new Promise(function (resolve) {
            const promises = [];
            var members = totalMembers.split(",").join("");
            for (var i = 0; i <= members; i += 20) {
                promises.push(new Promise(function (resolve, reject) {
                    got(`${url}members/?offset=${i}&sort=last_visited&desc=1`)
                        .then(response => {
                            jsdom.env(response.body, ["http://code.jquery.com/jquery.js"], (error, window) => {
                                const test = window.$('a.memName');
                                test.each(function () {
                                    const id = this.href.match(/\d+/)[0];
                                    dataArray.push(id);
                                    resolve();

                                });
                            });
                        })
                        .catch(error => {
                            console.log(error.response.body);
                            reject(error);
                        });
                }));
            }
            Promise.all(promises).then(() => {
                resolve();
            }).catch(error => {
                console.log(error.response.body);
            });
        }).then(() => {
            var file = fs.createWriteStream("data.txt");
            for (var i = 0; i < dataArray.length; i++) {
                streamify([dataArray[i]]).pipe(file).setMaxListeners(0);
                streamify(["\n"]).pipe(file);
            }
        }).catch(error => {
            console.log(error.response.body);
        });
    }).catch(error => {
        console.log(error.response.body);
    });
