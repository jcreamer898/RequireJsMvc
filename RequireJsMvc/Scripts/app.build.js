({
    appDir: "./",
    dir: "../Scripts-Build",
    baseUrl: "./",
    mainConfigFile: "app/common.js",
    modules: [{
        name: "app/common",
        include: [ "jquery" ]
    }, {
        name: "app/main/index",
        exclude: [ "app/common" ]
    }, {
        name: "app/main/about",
        exclude: ["app/common"]
    }],
    onBuildWrite: function (moduleName, path, contents) {
        //Always return a value.
        //This is just a contrived example.
        if (moduleName === "app/common") {
            return contents.replace("Scripts", "Scripts-Build");
        }
        return contents;
    },
})