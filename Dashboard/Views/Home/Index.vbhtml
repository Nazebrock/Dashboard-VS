<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
<head>
    <title>Dashboard</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link href=../../Content/bootstrap.css rel="stylesheet">
    <link href=../../Content/sb-admin.css rel="stylesheet">

    <script src="Bootstrap/js/Bootstrap.js"></script>
    <script src="../../Scripts/jquery-1.10.2.js"></script>
    <script src="Bootstrap/js/plugins/flot/jquery.flot.js"></script>
    <script>

        var source =  'http://pp-law.imaginatio.fr/checker';
        $(#1Time).append(source.LastIndexAt);

        $(function () {
            $.plot("#placeholder", [[[0, 0], [1, 1]]]);
        });

        var $traffic_options = {
            lines: { show: true },
            points: { show: true }
        };
        $(function () {

            var traffic = [[4, 5], [0, 1]];
            $.plot("#traffic", traffic);

        });
    </script>

</head>
<body>
    <div class="wrapper">
        <nav class="navbar navbar-default navbar-fixed-top" role="navigation">

            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".sidebar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#" style="height:50px">Dashboard</a>
            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <ul class="nav navbar-nav">
                <li class="dropdown">
                    <button class="btn btn-default dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown">
                        Signe Vitaux
                        <span class="caret"></span>
                    </button>
                    <ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu1">
                        <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Server</a></li>
                        <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Soft</a></li>
                        <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Base de donnée</a></li>
                    </ul>
                </li>
                <li class="dropdown">
                    <button class="btn btn-default dropdown-toggle" type="button" id="dropdownMenu2" data-toggle="dropdown">
                        Statistiques
                        <span class="caret"></span>
                    </button>
                    <ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu2">
                        <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Traffic</a></li>
                        <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Base de donnée</a></li>
                        <li role="presentation"><a role="menuitem" tabindex="-1" href="#"></a></li>
                    </ul>
                </li>
            </ul>
            <div class="navbar-default navbar-static-side" role="navigation">
                <div class="sidebar-collapse">
                    <ul class="nav" id="side-menu">
                        <li class="panel panel-default">
                            <div class="panel-heading">Etat</div>
                            <div class="panel-body">
                                <div class="table-responsive">
                                    <table class="table table-bordered table-hover table-striped">
                                        <thead>
                                            <tr>
                                                <th>Entitée</th>
                                                <th>Etat</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                        <td>Server</td>
                                        <td class="success">up</td>
                                        </tbody>
                                        <tbody>
                                        <td>Soft</td>
                                        <td class="danger">crash</td>
                                        </tbody>
                                        <tbody>
                                        <td>Base de Donnée</td>
                                        <td class="warning">Erreur</td>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </li>
                        <li role="presentation"><a href="test.html">Test</a></li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>


    <div id="page-wrapper">
        <div class="col-lg-12">
            <h1>Dashboard <small>| Overview</small></h1>
        </div>
        <div class="col-lg-5">
            <div class="panel panel-default">
                <div class="panel-heading">
                    Traffic
                </div>

                <div class="panel-body">
                    <div id="traffic" style="width:600px;height:300px"></div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-4">
                <div class="panel-body">
                    <div class="table-responsive">
                        <table class="table table-bordered table-hover table-striped">
                            <thead>
                                <tr>
                                    <th>Source</th>
                                    <th>Date</th>

                                </tr>
                            </thead>
                            <tbody>
                            <td>Bofip</td>
                            <td>28/06/2014</td>

                            </tbody>
                            <tbody>
                            <td>Legifrance</td>
                            <td id="1Time"></td>

                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class="col-lg-5">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Traffic
                    </div>

                    <div class="panel-body">
                        <div id="placeholder" style="width:600px;height:300px"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</body>
</html>
