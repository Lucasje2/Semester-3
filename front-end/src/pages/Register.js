import React, {useEffect, useState} from 'react';

function Register () {
  const [Gebruikersnaam, setName]=useState("");
  const [Password, setPassword]=useState("");
  const[Email, setEmail]=useState("");
  const[Message, setMessage]=useState("");

  let handleSubmit = async (e) => { e.preventDefault();
  try{
    let res = fetch("http://localhost:60671/api/Registreren", {
    method: "Post",
    headers: {
     "Content-Type": "text/plain"
    },
    body:JSON.stringify({
      Gebruikersnaam: Gebruikersnaam,
      Wachtwoord: Password,
      Email: Email,
    }),
  });
  let resJson = res.json();
if( res.status === 200){
  setName("");
 setPassword("");
 setMessage("User created succefully");
} else{
  setMessage("Some error occured");
}
} catch (err){
  console.log(err);
  console.log(Message)
} };

return (
<div>
<h1> Registreren</h1>
<form onSubmit={handleSubmit}>
<input type="text" placeholder='Gebruikersnaam' value={Gebruikersnaam} onChange={(e)=>{setName(e.target.value)}}/><br /> <br />
<input type="text"  placeholder='Password' value={Password} onChange={(e)=>{setPassword(e.target.value)}}/><br /> <br />
<input type="text"  placeholder='Email' value={Email} onChange={(e)=>{setEmail(e.target.value)}}/><br /> <br />
<button type="submit">createuser</button>
</form>
</div>


)

};
export default Register