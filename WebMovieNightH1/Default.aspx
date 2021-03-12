<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebMovieNightH1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>

    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl" crossorigin="anonymous" />
    <link rel="stylesheet" href="style.css" />
    <link
        href="https://fonts.googleapis.com/css2?family=Fascinate&family=Limelight&family=Roboto:wght@400;700&display=swap"
        rel="stylesheet" />
</head>


<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">Movie Night</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup"
                aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <div class="navbar-nav">
                    <a class="nav-link active" aria-current="page" href="#">Home</a>
                    <a class="nav-link" href="#">Update</a>
                    <a class="nav-link" href="#">Insert</a>
                    <a class="nav-link" href="#">Delete</a>
                </div>
            </div>
        </div>
    </nav>
    <header class="headerbox">
        <h1>Movie Night</h1>

    </header>

    <main class="container-fluid">
        <div class="row">
            <div class="col-md-8">
                <div class="welcome">
                    <h2>Welcome</h2>
                    <p>
                        Here you can get info on movies and actors from our list. You can make your own list and search
                        <strong>IMDB</strong> for further info. Lorem ipsum dolor sit amet consectetur adipisicing elit.
                        Placeat cumque
                        veniam vel magnam tempora nostrum deleniti velit accusantium! Accusamus deleniti officia non
                        totam perferendis corrupti, explicabo numquam tempore quaerat minima! Lorem ipsum dolor sit,
                        amet consectetur adipisicing elit. Fuga obcaecati voluptas quis placeat quo recusandae.
                        Voluptatum, adipisci in! Ipsam explicabo fugiat quo officiis nam tempora. Illum dolores vel
                        optio corporis!

                    </p>
                    <div class="Search our list">
                        <h2>Lists</h2>
                        <p>
                            To see our list click the button.
                        </p>

                       <%--Prints only the last movie of the list--%>
                        <form id="form1" runat="server">
                            <div>
                                <h1>
                                    <asp:Label ID="lblTitle" runat="server" Text="List of movies"></asp:Label></h1>
                                <p>
                                    <asp:Button runat="server" Text="GetLIst" OnClick="Unnamed1_Click" />
                                </p>
                                <p>
                                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                                </p>
                            </div>
                        </form>
                    </div>
                    </div>

                    <div class="ourlist">
                        <h2>Our list</h2>
                        <ol>
                            <li>Avatar</li>
                            <li>The Shining</li>
                            <li>Alien</li>
                            <li>As good as it gets</li>
                        </0l>
                    </div>
                    <div>
                        <h3>Didn't find what you wanted?</h3>
                        <p>Need info on other movies or actors?</p>
                        <form action="https://www.imdb.com/find" autocomplete="off" method="GET" role=""
                            target="_blank">
                            <label for="movies">IMDB</label>
                            <input class="form-control" type="text" placeholder="Type in movie or actor" id="movies"
                                name="q" required>
                            <button>Search </button>
                        </form>
                    </div>
                    <hr />
                    <div class="imgcontainer">
                        <div class="row g-0">
                            <div class="col">
                                <a href="https://www.imdb.com/title/tt0499549/?ref_=nv_sr_srsg_3"
                                    target="_blank">
                                    <img class=" img-fluid"
                                        src="https://m.media-amazon.com/images/M/MV5BMTYwOTEwNjAzMl5BMl5BanBnXkFtZTcwODc5MTUwMw@@._V1_UX182_CR0,0,182,268_AL_.jpg"
                                        alt="Avatar poster"></a>
                            </div>
                            <div class="col">
                                <a href="https://www.imdb.com/title/tt0081505/?ref_=fn_al_tt_1"
                                    target="_blank">
                                    <img class="img-fluid"
                                        src="https://m.media-amazon.com/images/M/MV5BZWFlYmY2MGEtZjVkYS00YzU4LTg0YjQtYzY1ZGE3NTA5NGQxXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg"
                                        alt="The shining poster"></a>
                            </div>
                            <div class="col">
                                <a href="https://www.imdb.com/title/tt0078748/?ref_=fn_al_tt_1"
                                    target="_blank">
                                    <img class="img-fluid"
                                        src="https://m.media-amazon.com/images/M/MV5BMmQ2MmU3NzktZjAxOC00ZDZhLTk4YzEtMDMyMzcxY2IwMDAyXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX182_CR0,0,182,268_AL_.jpg"
                                        alt="Alien poster" /></a>
                            </div>
                            <div class="col">
                                <a href="https://www.imdb.com/title/tt0119822/?ref_=nv_sr_srsg_0"
                                    target="_blank">
                                    <img class="img-fluid"
                                        src="https://m.media-amazon.com/images/M/MV5BNWMxZTgzMWEtMTU0Zi00NDc5LWFkZjctMzUxNDIyNzZiMmNjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg"
                                        alt="As good as it gets poster" /></a>
                            </div>
                        </div>
                    </div>
                    <div class="tablecontainer">
                        <h2>INFO</h2>
                        <p>
                            In the table below you can get more info on the <span>movies</span> and <span>actors</span>
                            by clicking the links in the list.
                        </p>
                        <div class="table-responsive">
                            <table class="table table-dark table-striped">
                                <thead>
                                    <th>ID</th>
                                    <th>Title</th>
                                    <th>Year</th>
                                    <th colspan="2">Actors</th>
                                    <th>About</th>
                                    <th>Genre</th>

                                </thead>
                                <tbody>
                                    <tr>
                                        <td>1</td>
                                        <td><a href="https://www.imdb.com/title/tt0499549/?ref_=nv_sr_srsg_3"
                                            target="_blank">Avatar</a>
                                        </td>
                                        <td>2009</td>
                                        <td><a href="https://www.imdb.com/name/nm0941777/?ref_=tt_ov_st_sm"
                                            target="_blank">Sam
                                                Worthington</a></td>
                                        <td><a href="https://www.imdb.com/name/nm0000244/?ref_=nv_sr_srsg_0"
                                            target="_blank">Sigourney
                                                Weaver</a></td>
                                        <td>A paraplegic Marine torn between following his orders and protecting the new
                                            world he feels is his home.</td>
                                        <td>Fantasy</td>
                                    </tr>
                                    <tr>
                                        <td>2</td>
                                        <td><a href="https://www.imdb.com/title/tt0081505/?ref_=fn_al_tt_1"
                                            target="_blank">The
                                                Shining</a>
                                        </td>
                                        <td>1980</td>
                                        <td><a href="https://www.imdb.com/name/nm0000197/?ref_=fn_al_nm_1"
                                            target="_blank">Jack
                                                Nicholson</a></td>
                                        <td><a href="https://www.imdb.com/name/nm0001167/?ref_=tt_ov_st_sm"
                                            target="_blank">Shelley
                                                Duvall</a></td>
                                        <td>A family heads to an isolated hotel. A sinister presence influences the
                                            father. His psychic son sees horrific things.</td>
                                        <td>Horror</td>

                                    </tr>
                                    <tr>
                                        <td>3</td>
                                        <td><a href="https://www.imdb.com/title/tt0078748/?ref_=fn_al_tt_1"
                                            target="_blank">Alien</a>
                                        </td>
                                        <td>1979</td>
                                        <td><a href="https://www.imdb.com/name/nm0000244/?ref_=nv_sr_srsg_0"
                                            target="_blank">Sigourney
                                                Weaver</a></td>
                                        <td><a href="https://www.imdb.com/name/nm0000643/?ref_=tt_ov_st_sm"
                                            target="_blank">Tom
                                                Skerritt</a>
                                        </td>
                                        <td>A space merchant vessel crew member is attacked by a mysterious life form.
                                        </td>
                                        <td>Sci-Fi</td>

                                    </tr>
                                    <tr>
                                        <td>4</td>
                                        <td><a href="https://www.imdb.com/title/tt0119822/?ref_=nv_sr_srsg_0"
                                            target="_blank">As
                                                good as
                                                it gets</a></td>
                                        <td>1997</td>
                                        <td><a href="https://www.imdb.com/name/nm0000197/?ref_=fn_al_nm_1"
                                            target="_blank">Jack
                                                Nicolson</a>
                                        </td>
                                        <td><a href="https://www.imdb.com/name/nm0000166/?ref_=tt_ov_st_sm"
                                            target="_blank">Helen
                                                Hunt</a>
                                        </td>
                                        <td>Frindship between a single mother and waitress, a misanthropic author, and a
                                            gay artist.</td>
                                        <td>Comedy</td>

                                    </tr>
                                </tbody>

                            </table>
                        </div>
                    </div>
                    <div>
                        <form action="/Liste" autocomplete="off" method="GET" role="" target="_blank">
                            <label for="comment">Please leave a comment</label>
                            <br>
                            <textarea id="comment" rows="3" cols="40" name="comment" placeholder="Text"
                                required></textarea>
                            <br>
                            <button>Send</button>
                        </form>
                    </div>
                </div>

            </div>

            <!--QUOTES-->
            <div class="col-md-4">
                <div class="quotes">
                    <h4>Quotes</h4>
                    <blockquote class="blockquote">
                        <p>
                            "Sky people cannot learn, you do not see."
                        </p>
                        <footer class="blockquote-footer">Avatar</footer>
                    </blockquote>
                    <blockquote class="blockquote">
                        <p>
                            "This Is Ripley, Last Survivor Of The Nostromo...Signing Off."
                        </p>
                        <footer class="blockquote-footer">Alien</footer>
                    </blockquote>
                    <blockquote class="blockquote">
                        <p>
                            “Jack Torrance: Mr. Grady, you were the caretaker here.<br>
                            Delbert Grady: I'm sorry to differ with you sir, but you are the caretaker. You've always
                            been
                            the
                            caretaker. I should know sir. I've always been here.”
                        </p>
                        <footer class="blockquote-footer">The shining</footer>
                    </blockquote>
                    <blockquote class="blockquote">
                        <p>
                            “The best thing you have going for you is your willingness to humiliate yourself.”
                        </p>
                        <footer class="blockquote-footer">As good as it gets</footer>
                    </blockquote>
                </div>
                <!-- youtube trailers-->
                <div class="container-fluid">
                    <h4>Trailers</h4>
                    <iframe width="420" height="315" src="https://www.youtube.com/embed/5PSNL1qE6VY"></iframe>
                    <iframe width="420" height="315" src="https://www.youtube.com/embed/S014oGZiSdI"></iframe>
                    <iframe width="420" height="315" src="https://www.youtube.com/embed/LjLamj-b0I8"></iframe>
                    <iframe width="420" height="315" src="https://www.youtube.com/embed/dlLKo-_slWg"></iframe>
                </div>
            </div>

        </div>
    </main>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.6.0/dist/umd/popper.min.js"
        integrity="sha384-KsvD1yqQ1/1+IA7gi3P0tyJcT3vR+NdBTt13hSJ2lnve8agRGXTTyNaBYmCR/Nwi"
        crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.min.js"
        integrity="sha384-nsg8ua9HAw1y0W1btsyWgBklPnCUAFLuTMS2G72MMONqmOymq585AcH49TLBQObG"
        crossorigin="anonymous"></script>
</body>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.6.0/dist/umd/popper.min.js"
    integrity="sha384-KsvD1yqQ1/1+IA7gi3P0tyJcT3vR+NdBTt13hSJ2lnve8agRGXTTyNaBYmCR/Nwi"
    crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.min.js"
    integrity="sha384-nsg8ua9HAw1y0W1btsyWgBklPnCUAFLuTMS2G72MMONqmOymq585AcH49TLBQObG"
    crossorigin="anonymous"></script>
</body>
</html>
