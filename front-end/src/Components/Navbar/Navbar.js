import React, { Component } from 'react';
import { MenuItems } from "./MenuItems"
import './Navbar.css';
import GoogleLogin from 'react-google-login';

class Navbar extends Component {
    state = { clicked: false }

    handleFailure = (result) => {
        alert(result);
    }

    handleLogin = (googleData) => {
        console.log(googleData);
    };

    handleClick = () => {
        this.setState({clicked: !this.state.clicked})
    }

    render(){
        return(
            <nav className="NavbarItems">
                <h1 className='navbar-logo'>FlySafe<i className='fab fa-react'></i></h1>
                <div className='menu-icon' onClick={this.handleClick}>
                    <i className={this.state.clicked ? 'fas fa-times' : 'fas fa-bars'}></i>

                </div>
                <ul className={this.state.clicked ? 'nav-menu active' : 'nav-menu'}>
                    { MenuItems.map((item, index) => {
                        return(
                            <li key={index}>
                                <a className={item.cName} href={item.url}>
                                    {item.title}
                                 </a>
                            </li>
                        )
                    })}
                <GoogleLogin clientId={process.env.REACT_APP_GOOGLE_CLIENT_ID} buttonText="Log in with Google" onSuccess={this.handleLogin} onFailure={this.handleFailure} cookiePolicy={'single_host_origin'}></GoogleLogin>
                </ul>

            </nav>
            
        )
    }
}

export default Navbar