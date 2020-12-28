function renderCircle(ctx, x, y, r, party) {
    var style = PartyStyles[party];
    if (style) {
        ctx.strokeStyle = style.outline;
        ctx.fillStyle = style.fill;
    } else {
        ctx.strokeStyle = "black";
        ctx.fillStyle = "#929292";
    }
    //ctx.globalAlpha = 0.4;
    ctx.beginPath();
    ctx.arc(x, y, r, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.fill();
    //ctx.globalAlpha = 1.0;
}

function onTemplateBubble(o, e) {
    //console.log("Bubble onTemplateBubble ");

    var desiredSize = 46;
    //var desiredSize = 94;
    return {
        measure: function (measureInfo) {
            var cont = measureInfo.context;
            var data = measureInfo.data;
            measureInfo.width = desiredSize;
            measureInfo.height = desiredSize;
        },

        render: function (renderInfo) {
            var ctx = renderInfo.context;
            if (renderInfo.isHitTestRender) {
                ctx.fillStyle = renderInfo.data.actualItemBrush.fill;
            } else {
                ctx.fillStyle = "black";
            }

            var halfWidth = Math.round(renderInfo.availableWidth / 2.0);
            var halfHeight = Math.round(renderInfo.availableHeight / 2.0);

            var cx = renderInfo.xPosition;
            var cy = renderInfo.yPosition;

            var x = renderInfo.xPosition - halfWidth;
            var y = renderInfo.yPosition - halfHeight;

            if (renderInfo.isHitTestRender) {
                //ctx.fillRect(cx - rectHalf, cy - rectHalf, rectSize, rectSize);
                ctx.fillRect(x, y, renderInfo.availableWidth, renderInfo.availableHeight);

            } else {

                var data = renderInfo.data;
                var code = data.item.StateSymbol.toString();

                //ctx.globalAlpha = 0.4;
                //ctx.strokeStyle = "red";
                //ctx.strokeRect(x, y, renderInfo.availableWidth, renderInfo.availableHeight);
                //ctx.strokeRect(cx, cy, renderInfo.availableWidth, renderInfo.availableHeight);

                var viewportHeight = renderInfo.passInfo.viewportHeight;
                var viewportRatio = viewportHeight / 500.0;
                var markerSize = viewportRatio * desiredSize;
                var markerHalf = markerSize / 2.0;

                //var mx = cx - markerHalf;
                //var my = cy - markerHalf;
                var fontSize = Math.round(viewportRatio * 10);
                var lineSize = Math.round(viewportRatio * 6);

                var ElectionMode = data.item.ElectionMode;
                var winnerParty = data.item.WinnerParty;
                var looserParty = data.item.LooserParty;
                var heldElection = data.item.StateHeldElections;
                if (!heldElection) {
                    winnerParty = "NoStatehood";
                }
                //renderCircle(ctx, cx, cy, 16, winnerParty);
                renderCircle(ctx, cx, cy, markerHalf, winnerParty);

                //ctx.fillStyle = "#30A510";
                //ctx.fillRect(x, y, renderInfo.availableWidth, renderInfo.availableHeight);

                ctx.font = "normal " + fontSize + "px Verdana";
                ctx.textBaseline = "middle";
                ctx.textAlign = "center";

                ctx.fillStyle = "white";
                ctx.fillText(code, cx, cy - lineSize);

                var winnerValue = 0;
                var looserValue = 0;

                if (heldElection) {
                    if (ElectionMode == "Popular") {
                        //winnerValue = abbreviate(data.item.WinnerVotes);
                        winnerValue = data.item.WinnerPercentage.toFixed(0) + "%";
                        looserValue = 0; //abbreviate(data.item.LooserVotes);
                    } else if (ElectionMode == "Percent") {
                        winnerValue = data.item.WinnerPercentage.toFixed(0) + "%";
                        looserValue = 0; //data.item.LooserPercentage;
                    } else {
                        winnerValue = data.item.WinnerElectors;
                        looserValue = data.item.LooserElectors;
                    }

                    if (winnerValue > 0 || winnerValue != "0.0") {
                        ctx.fillText(winnerValue, cx, cy + lineSize);
                        //ctx.strokeStyle = "#24C315"; 
                        //ctx.strokeRect(mx, my, markerSize, markerSize);
                    }

                    var looserParty = data.item.LooserParty;
                    if (looserParty != "NoStatehood" && winnerParty != "Tossup") {

                        if (looserValue > 0 || looserValue != "0.0") {

                            var smallSize = Math.round(markerHalf / 3);
                            var sx = cx + markerHalf - smallSize;
                            var sy = cy + markerHalf - smallSize;
                            renderCircle(ctx, sx, sy, smallSize, looserParty);

                            //ctx.font = "normal 10px Verdana";
                            ctx.textBaseline = "middle";
                            ctx.textAlign = "center";
                            ctx.fillStyle = "white";
                            ctx.fillText(looserValue, sx, sy);
                        }
                    }
                }

                //if (code == "TX") {
                //    console.log("ElectionBubbles Marker  " + code + " " + ElectionMode + " " + winnerValue + " " + looserValue );
                //}

            }
        }
    }
}

igRegisterScript("onTemplateBubble", onTemplateBubble, true);