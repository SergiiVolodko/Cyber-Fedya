﻿class ApiRepository extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            baseUrl: props.baseUrl,
            error: null,
            isLoaded: false
        };
    }

    getRequest(url, onSuccess, onFailure) {
        var token = localStorage.getItem('access_token');

        $.ajax({
            type: "GET",
            crossDomain: true,
            beforeSend: function (xhr) {
                xhr.setRequestHeader('Authorization', 'Bearer ' + token);
            },
            url: this.state.baseUrl + url,
            success: function(data) {
                onSuccess(data);
            },
            error: function(e)
            {
                //self.setState({
                //   isLoaded: true,
                //})
                onFailure();
            }
        });
    }

    postRequest(url, body, onSuccess, onFailure) {
        var token = localStorage.getItem('access_token');

        $.ajax({
            type: "POST",
            dataType: "json",
            crossDomain: true,
            contentType: "application/json; charset=utf-8",
            beforeSend: function (xhr) {
                xhr.setRequestHeader('Authorization', 'Bearer ' + token);
            },
            url: this.state.baseUrl + url,
            data: JSON.stringify(body),
            success: function(data) {
                onSuccess(data);
            },
            error: function(e)
            {
                //self.setState({
                //   isLoaded: true,
                //})
                onFailure();
            }
        });
    }

}