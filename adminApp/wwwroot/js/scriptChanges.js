var globData=null;
var globFeedbck = null;
var temp = 0;
//cannot use cont fr connurl as it will use multiple times as global scope, hence treat like multiple declarations
var awsLink = "a9ce74ec5912947ebac9f77ae44c5cda-14636750.us-east-1.elb.amazonaws.com";
var connUrl = "http://"+awsLink+":8080";
function fetchData() {
    const url = connUrl + '/allPlaylist';
    fetch(url,{method:'GET'})
    .then((response) => {
        return response.json();
    })
    .then((data) => {
        globData = data;
        capturePlaylist(globData);
    });

    const urll = connUrl + '/allFeedbacks';
    fetch(urll,{method:'GET'})
    .then((response)=>{ return response.json(); })
    .then((data)=>{
        globFeedbck = data;
        captureFeedback(globFeedbck);
    });
}

function delUrl(id) {
    const urlDel = connUrl + "/delPlaylist?key=" + id;
    fetch(urlDel, { method: 'GET' })
    .then((response) => {
        if (response.status === "200") {
            alert("Data has been deleted");
            window.location.reload();
        }
    })
    .catch((error) => {
        alert("Entry could not be deleted");
    });
}

//toggle functionality
function showEdit(){
    var dv = document.getElementById("editPlaylist");
    if(dv.style.display==="none"){
        dv.style.display = "block";
    }else{
        dv.style.display = "none";
    }
}
function showAdd(){
    var dv = document.getElementById("addPlaylist");
    if(dv.style.display==="none"){
        dv.style.display = "block";
    }else{
        dv.style.display = "none";
    }
}
//toggle functionality

//get current obj url
function findUrl() {
    let sel = document.getElementById("editSel").value;
    //find sel as an ID in globalData;
    while (temp < globData.length) {
        if (sel == globData[temp].id) {
            break;
        }
        temp++;
    }
    document.getElementById("editUrl").value = globData[temp].playlist_url;
}

//edit playlist
function editPlaylist() {
    let currId = document.getElementById("editSel").value;
    var dat = {
        "id": currId,
        "playlist_name": globData[temp].playlist_name,
        "playlist_url": document.getElementById("editUrl").value
    }
    //fetch api to send the JSON
    const editUrl = connUrl + "/editIt?key=" + currId;
    fetch(editUrl, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(dat)
    })
        .then((response) => {
            if (response.ok) {
                alert("Data Edited");
                window.location.reload();
            }
            if (response.status == 422) {
                alert("Https Error:" + response.status + "-Check the URL format to be 0-100");
            }
        });
}
//edit playlist

//addition of playlist
function addPlaylist(){
    let resp = {
        "playlist_name" : document.getElementById("selType").value,
        "playlist_url"  : document.getElementById("addUrl").value
    };
    const entrypoint = connUrl + "/addPlaylist";
    fetch(entrypoint, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(resp)
    })
    .then((response) => {
        if (response.ok) {
            alert("data Added");
            window.location.reload();
        }
        if (response.status == 422) {
            alert("Https Error:"+response.status+"-Check the URL format to be 0-100");
        }
    })
    .catch((error) => {
        alert(error);
     });
}
//addition of playlist

function capturePlaylist(data){
    var tabBody = document.getElementById("playlistEditor");
        for(let i=0;i<data.length;i++){
            let row = tabBody.insertRow(i);
            let cel0 = row.insertCell(0);
            let cel1 = row.insertCell(1);
            let cel2 = row.insertCell(2);
            let cel3 = row.insertCell(3);
            cel0.innerHTML = data[i].id;
            cel1.innerHTML = data[i].playlist_name;
            cel2.innerHTML = data[i].playlist_url;
            let delButton  = document.createElement("button");
            delButton.setAttribute("class","btn btn-danger");
            delButton.setAttribute("onClick","delUrl(this.id)");
            delButton.setAttribute("id",data[i].id);
            delButton.innerHTML = "Delete";
            cel3.append(delButton);
            //add select options with ids to edit, so no non-saved ids undergo edit
            let select = document.getElementById('editSel');
            let opt = document.createElement('option');
            opt.setAttribute("value",data[i].id);
            opt.innerHTML = data[i].id;
            select.appendChild(opt);
        }
}

function captureFeedback(data){
    var tabBody = document.getElementById("feedbackEditor");
    for(let i=0;i<data.length;i++){
        let row = tabBody.insertRow(i);
        let cel0 = row.insertCell(0);
        let cel1 = row.insertCell(1);
        let cel2 = row.insertCell(2);
        let cel3 = row.insertCell(3);
        cel0.innerHTML = data[i].id;
        cel1.innerHTML = data[i].rec;
        cel2.innerHTML = data[i].email;
        cel3.innerHTML = data[i].comment;
        let resButton  = document.createElement("button");
        resButton.setAttribute("class","btn btn-success");
        resButton.setAttribute("onClick","sendEmail(this.id)");
        resButton.setAttribute("id",data[i].email);
        resButton.innerHTML = "Send Response";
        row.insertCell(4).append(resButton);
    }
}

function sendEmail(email){
    let str = "Respond to:\n" + email;
    var res = window.prompt(str,"");
    if(res === null || res === ""){
        alert("you cancelled send");
    }else{
        let resp = {
            "email" : email,
            "response" : res
        };
        const entrypoint = connUrl + "/sendEmail";
        fetch(entrypoint, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(resp)
        })
        .then((response) => {
            if (response.ok) {
                alert("Email sent");
            }
        })
        .catch((error) => {
            alert("Internal server issue could not send email");
         });
    }
}