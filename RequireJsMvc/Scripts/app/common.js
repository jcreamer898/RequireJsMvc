require.config({
    baseUrl: "/Scripts/",
    paths: {
        "jquery": "jquery-1.9.1"
    }
});

require(["app/app"], function (app) {
    app.init();
});
