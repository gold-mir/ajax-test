var heckCount = 1;
var cat;
var ಠ_ಠ = function(){
    alert ("Unknown error");
}

var test = function(){
    console.log("test");
}

var writeHeckDisplay = function(data){
    $("#heckdisplay").empty();
    data.forEach(function(item){
        var times = item.split("Heck the number ")[1];
        $("#heckdisplay").append(`<li>${"🤔".repeat(times)}</li>`);
    })
}
var tempOutput = [];
var otherOutput = [];

function getAllCardsFromScryfallQuery(queryString, finished, cards = []){

    var ajaxcall = {
        url: queryString,
        type: "GET",
        dataType: "json",
        success: function(result)
        {
            cards.push.apply(cards, result.data);

            if(result.has_more){
                setTimeout(function(){getAllCardsFromScryfallQuery(result.next_page, finished, cards);}, 50);
            } else {
                finished(cards);
            }
        },
        error: ಠ_ಠ
    }
    $.ajax(ajaxcall);
}

function setTempOutputAndPrint(cards){
    console.log(cards);
    tempOutput = cards;
}

function setOtherOutputAndPrint(cards){
    otherOutput = cards;
}

function setTempOutputAndPrintAllCards(cards){
    setTempOutputAndPrint(cards);
    cards.forEach(function(card){
        console.log(`Name: ${card.name}, Cost: ${card.mana_cost} (${card.cmc} cmc)`);
    });
}

$(document).ready(function(){

    $("button[name=send-cat]").click(function(event){
        var thing = {Name: "Heck", Stuff: [1, 2, 3, 4, 5]};
        console.log(JSON.stringify(thing));
        $.ajax({
            url: "/catto",
            type: "POST",
            traditional: true,
            dataType: "json",
            data: {input: [JSON.stringify(cat)]},
            success: function(data){
                console.log(data);
            },
            error: ಠ_ಠ
        });
    });

    $("#heck-number-update").submit(function(event){
        event.preventDefault();
        var newHecks = parseInt($("#heck-number-update input[name=heck-count]").val());
        if(!isNaN(newHecks)){
            if(newHecks > 0){
                heckCount = newHecks;
            }
        }
        console.log(`Heck Count: ${heckCount}`);
    });
    $("button[name=random-number-button]").click(function(event){
        $.ajax({
            url: "/rand",
            type: "GET",
            success: function(data){
                console.log(data);
            },
            error: ಠ_ಠ
        });
    });
    $("button[name=heck-button]").click(function(event){
        $.ajax({
            url: "/heck",
            type: "POST",
            data: {
                numberOfHecks: heckCount,
                data: {name: "fred", occupation: "some guy", dogs: "3", action: "hi", stuff: [1, 2, 3, 4]}
            },
            success: function(data){
                cat = data;
            },
            error: ಠ_ಠ
        });
    });
});
