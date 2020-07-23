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

function GetDestinationName(data) {
    let destinationNames = [];
    
    data.forEach(function (item) {
        destinationNames.push(item.Name);
    });

}