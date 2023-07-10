$(document).ready(function () {
    function ViewModel() {
        var self = this;
        debugger;
        self.Id = ko.observable("");
        self.Heading = ko.observable("");
        self.PageTitle = ko.observable("");
        self.ShortDescription = ko.observable("");
        self.ImageUrl = ko.observable("");
        self.Release = ko.observable("");
        self.Visible = ko.observable("");


        $.ajax({
            type: "GET",
            url: "https://localhost:43761/api/MyAnimes",
            success: function (response) {

                alert("Successful");
            },

            error: function (error) {
                console.log("Error fetching players data:", error);
            }
        });

        function populateTable(data) {


            for (var i = 0; i < data.length; i++) {
                var player = data[i];
                console.log(player);

                var playerDiv = $('<div class="col-md-4 mb-3">');
                var playerImage = $('<div class="position-relative">');
                var image = $('<img class="img-fluid rounded-3 mb-1" alt="' + player.name + '">');
                image.attr('src', player.imageUrl);
                image.css('width', '100%');
                image.css('object-fit', 'cover');
                image.css('height', '200px');
                playerImage.append(image);

                var playerInfo = $('<div class="bottom-0 start-0 p-2 w-100" style="background-color: rgba(146,146,146,0.5);">');
                var playerName = $('<a class="h3 fw-bolder text-decoration-none link-light stretched-link">');
                playerName.attr('href', '#!');
                playerName.text(player.name);
                playerInfo.append(playerName);
                playerImage.append(playerInfo);
                playerDiv.append(playerImage);

                if (userIsAuthenticated) {
                    var editButton = $('<div class="d-inline-block">');
                    var editLink = $('<a class="btn btn-primary">');
                    editLink.attr('asp-page', '/Admin/Animes/Edit');
                    editLink.attr('asp-route-id', player.id);
                    editLink.text('Edit');
                    editButton.append(editLink);
                    playerDiv.append(editButton);

                    var deleteButton = $('<div class="d-inline-block mb-2">');
                    var deleteLink = $('<a class="btn btn-danger">');
                    deleteLink.attr('asp-page', '/Admin/Animes/Delete');
                    deleteLink.attr('asp-route-id', player.id);
                    deleteLink.text('Delete');
                    deleteButton.append(deleteLink);
                    playerDiv.append(deleteButton);
                }

                $('.row.gx-5').append(playerDiv);
            }

            $('.navbar-brand.text-danger').attr('asp-page', '/Index');
            $('.navbar-toggler').attr('data-bs-toggle', 'collapse');
            $('.navbar-toggler').attr('data-bs-target', '.navbar-collapse');
            $('.navbar-toggler').attr('aria-controls', 'navbarSupportedContent');
            $('.navbar-toggler').attr('aria-expanded', 'false');
            $('.navbar-toggler').attr('aria-label', 'Toggle navigation');
        }
    }

    var viewModel = new ViewModel();
    ko.applyBindings(viewModel);

    $('#fetchList').submit(function (event) {
        event.preventDefault();
        /*debugger;*/
        viewModel.addPlayer();
    });

});



