import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import MediaRow from './MediaRow';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = { media: [], loading: true };
    }

    componentDidMount() {
        this.populateMediaData();
    }

    static renderMediaTable(media) {
        return (
            <table className='table table-striped' aria-labelledby="tableLabel">
                <thead>
                    <tr>
                        <th>Title</th>
                        <th>Author/Director</th>
                        <th>Type</th>
                    </tr>
                </thead>
                <tbody>
                    {media.map(item =>
                        <MediaRow media={item} />
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Home.renderMediaTable(this.state.media);

        return (
            <div>
                <h1 id="tableLabel" >Movies and Books</h1>
                <p>This is a bare bones coding exercise to demonstrate a React SPA application in .NET 5 with WebAPI repository and Dependency Injection.</p>

                {contents}

                <div className='container'>
                    <div class="row justify-content-end pr-4">
                        <Link className='btn btn-primary mr-2 mt-2 mb-4' to="/new-media">Add New</Link>
                    </div>
                </div>
            </div>
        );
    }

    async populateMediaData() {
        const response = await fetch('api/media');
        const data = await response.json();
        this.setState({ media: data, loading: false });
    }
}
