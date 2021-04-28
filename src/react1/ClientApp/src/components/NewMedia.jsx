import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export class NewMedia extends Component {
    static displayName = NewMedia.name;

    constructor(props) {
        super(props);
        this.state = {
            title: '',
            creator: '',
            contentType: 'Book'
        };
    }

    handleChange = (event) => {
        const target = event.target;
        const value = target.type === 'checkbox' ? target.checked : target.value;
        const name = target.name;

        this.setState({
            [name]: value
        });
    }

    handleSubmit = (event) => {
        fetch('api/media', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(this.state)
        }).then(response => {
            if (response.ok) {
                console.log("Media Added!");
                this.setState({
                    title: '',
                    creator: '',
                    contentType: 'Book'
                });
            }
            else {
                alert("Something Broke!");
            }
        });

        event.preventDefault();

        this.state = {
            title: '',
            creator: '',
            contentType: 'Book'
        };

    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <div className='container'>
                    <label className='m-2'>
                    Title:
                    </label>
                    <input className='m-2' type="text" value={this.state.title} name="title" onChange={this.handleChange} />
                </div>
                <div className='container'>
                    <label className='m-2'>
                    Author/Director:
                </label>
                    <input className='m-2' type="text" value={this.state.creator} name="creator" onChange={this.handleChange} />
                </div>
                <div className='container'>
                    <label className='m-2'>
                    Type:
                </label>
                    <select className='m-2' value={this.state.contentType} name="contentType" onChange={this.handleChange}>
                        <option value="Book">Book</option>
                        <option value="Movie">Movie</option>
                    </select>
                </div>
                <hr/>
                <div className='container'>
                    <div class="row justify-content-end pr-4">
                        <input className='btn btn-primary mr-2 mt-2 mb-4' type="submit" value="Submit" />
                        <Link className='btn btn-secondary mr-2 mt-2 mb-4' to="/">Back to List</Link>
                    </div>
                </div>
            </form>
        );
    }
}
