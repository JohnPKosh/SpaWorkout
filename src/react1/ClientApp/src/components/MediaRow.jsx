import React from 'react'

export default function MediaRow({ media }) {

    let cType = 'Movie';

    if (media.contentType === 'Book') {
        cType = 'Book'
    }
    return (
        <tr key={media.identifier}>
            <td>{media.title}</td>
            <td>
                {media.creator}
            </td>
            <td>{cType}</td>
        </tr>
    );
}

