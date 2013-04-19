define(["jquery", "app/main/index", "app/main/about"], function ( $, index, about ) {
    return {
        init: function() {
            console.log("INIT");
            index();
            about();
        }  
    };
});