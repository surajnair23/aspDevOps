var globData=null;
var globFeedbck = null;
function fetchData(){
    const url = 'http://localhost:8080/allPlaylist';
    fetch(url,{method:'GET'})
    .then((response) => {
        return response.json();
    })
    .then((data) => {
        globData = data;
        capturePlaylist(globData);
    });

    const urll = 'http://localhost:8080/allFeedbacks';
    fetch(urll,{method:'GET'})
    .then((response)=>{ return response.json(); })
    .then((data)=>{
        globFeedbck = data;
        captureFeedback(globFeedbck);
    });
}

function delUrl(id){
    alert("The playlist with id"+id+" has been deleted");
    //api to delete
    // fetch(url,{method:'DELETE'})
    // .then((response) => {
    //     return response.json();
    // })
    // .then((data) => {});
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
function findUrl(){
    var sel = document.getElementById("editSel");
    alert(globData[sel.value].playlist_url);
    document.getElementById("editUrl").value = globData[sel.value].playlist_url;
}

//edit playlist save
function editPlaylist(){
    var dat = {
        "id" : document.getElementById("editSel").value,
        "url": document.getElementById("editUrl").value
    }
    console.log(dat);
    //fetch api to send the JSON
    // fetch();
}
//edit playlist save

//addition of playlist
function addPlaylist(){
    let resp = {
        "type" : document.getElementById("selType"),
        "url"  : document.getElementById("addUrl")
    };
    
    // addition logic
    alert(resp);
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
        alert("email response sent");
        let resp = {
            "content" : res
        };
        //api to send email in json using "resp"
    }
}