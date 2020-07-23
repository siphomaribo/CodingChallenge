var data = [
    {
        name: "Sandals",
        country: "Jamaica",
        holidayRanking: 9
    },
    {
        name: "Auckland",
        country: "New Zealand",
        holidayRanking: 5
    },
    {
        name: "Suva",
        country: "Fiji",
        holidayRanking: 6
    },
    {
        name: "Apia",
        country: "Somoa",
        holidayRanking: 4
    },
    {
        name: "Nuku'alofa",
        country: "Tonga",
        holidayRanking: 10
    },
];

console.log("The Destination Names : " + GetDestinationName(data));

console.log("The Destinations holidayRanking > 4 : " + GetDestinationHolidayGreaterThanFour(data));

console.log("The Destinations holidayRanking sum is : " + GetDestinationHolidayGreaterThanFourAndTheirSum(GetDestinationHolidayGreaterThanFour(data)));
 

function GetDestinationName(data) {

    let destinationNames = [];
    data.forEach(function (item) {
        destinationNames.push(item.name);
    });

    return destinationNames;
}

function GetDestinationHolidayGreaterThanFour(data) {

    let destinations = [];
    data.forEach(function (item) {
        if (item.holidayRanking > 4)
            destinations.push(item);
    });

    return destinations;
}

function GetDestinationHolidayGreaterThanFourAndTheirSum(data) {

    let sum = 0;
    data.forEach(function (item) {
        sum = sum + item.holidayRanking
  
    });

    return sum;
}

//# sourceMappingURL=app.js.map