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
            //dataType: "json",
            crossDomain: true,
            beforeSend: function (xhr) {
                xhr.setRequestHeader('Authorization', 'Bearer ' + token);
            },
            url: this.state.baseUrl + url,
            //async: false,
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

    //dataType: "json",
    //crossDomain: true,
    //contentType: "application/json; charset=utf-8",
    //data: JSON.stringify(data),
}