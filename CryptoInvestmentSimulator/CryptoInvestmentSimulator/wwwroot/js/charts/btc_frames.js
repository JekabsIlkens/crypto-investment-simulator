﻿
// Loads all Bitcoin chart partial views in designated chartZone divs.
// Sets refresh intervals (with small delay) for dynamic chart updates when new data is collected.
// Adds event listeners for chart switching buttons.

window.addEventListener("load", (event) =>
{
	$('#chartZone1h').load("/Market/BTC1hChart");
	setInterval(function () { $('#chartZone1h').load("/Market/BTC1hChart"); }, 60000);
	document.getElementById("chartZone1h").style.display = "block";

	$('#chartZone4h').load("/Market/BTC4hChart");
	setInterval(function () { $('#chartZone4h').load("/Market/BTC4hChart"); }, 60250);
	document.getElementById("chartZone4h").style.display = "none";

	$('#chartZone8h').load("/Market/BTC8hChart");
	setInterval(function () { $('#chartZone8h').load("/Market/BTC8hChart"); }, 60500);
	document.getElementById("chartZone8h").style.display = "none";

	$('#chartZone24h').load("/Market/BTC24hChart");
	setInterval(function () { $('#chartZone24h').load("/Market/BTC24hChart"); }, 60750);
	document.getElementById("chartZone24h").style.display = "none";

	document.getElementById("1h").addEventListener("click", get1hChart);
	document.getElementById("4h").addEventListener("click", get4hChart);
	document.getElementById("8h").addEventListener("click", get8hChart);
	document.getElementById("24h").addEventListener("click", get24hChart);

	$('#activePositionZone').load("/Market/PositionsTableBTC");
	setInterval(function () { $('#activePositionZone').load("/Market/PositionsTableBTC"); }, 61000);
});
