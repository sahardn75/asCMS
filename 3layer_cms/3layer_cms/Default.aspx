<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_3layer_cms._Default" %>

<!DOCTYPE html>
<html lang="en">
<link href="css/bootstrap.css" rel="stylesheet" />
<script src="Scripts/jquery-1.11.3.js"></script>
<script src="js/bootstrap.min.js"></script>
<script type="text/javascript">
    function redirect() {
        var cook = document.cookie;
        var n = cook.search("\\*");
        if (n != -1) {
            window.location = "userHome.aspx";
        } else {
            window.location = "login.aspx";
        }
    }
</script>
<script type="text/javascript">
    function setCookie() {
        document.cookie = "logout";
        window.location = "login.aspx";
    }
</script>
<head>
    <title>صفحه اصلی</title>
    <style type="text/css">
        .navbar-brand {
            position: relative;
            z-index: 2;
        }

        .navbar-nav.navbar-right .btn {
            position: relative;
            z-index: 2;
            padding: 4px 20px;
            margin: 10px auto;
            transition: transform 0.3s;
        }

        .navbar .navbar-collapse {
            position: relative;
            overflow: hidden !important;
        }

            .navbar .navbar-collapse .navbar-right > li:last-child {
                padding-left: 10px;
            }

        .navbar .nav-collapse {
            position: absolute;
            z-index: 1;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            margin: 0;
            padding-right: 120px;
            padding-left: 80px;
            width: 43%;
        }

        .navbar.navbar-default .nav-collapse {
            background-color: #f8f8f8;
        }

        .navbar.navbar-inverse .nav-collapse {
            background-color: #ff0000;
        }

        .navbar .nav-collapse .navbar-form {
            border-width: 0;
            box-shadow: none;
        }

        .nav-collapse > li {
            float: right;
        }

        .btn.btn-circle {
            border-radius: 50px;
        }

        .btn.btn-outline {
            background-color: transparent;
        }

        .navbar-nav.navbar-right .btn:not(.collapsed) {
            background-color: #0b8fee;
            border-color: #0b8fee;
            color: rgb(255, 255, 255);
        }

        .navbar.navbar-default .nav-collapse,
        .navbar.navbar-inverse .nav-collapse {
            height: auto !important;
            transition: transform 0.3s;
            transform: translate(0px,-50px);
        }

            .navbar.navbar-default .nav-collapse.in,
            .navbar.navbar-inverse .nav-collapse.in {
                transform: translate(0px,0px);
            }


        @media screen and (max-width: 767px) {
            .navbar .navbar-collapse .navbar-right > li:last-child {
                padding-left: 15px;
                padding-right: 15px;
            }

            .navbar .nav-collapse {
                margin: 7.5px auto;
                padding: 0;
            }

                .navbar .nav-collapse .navbar-form {
                    margin: 0;
                }

            .nav-collapse > li {
                float: none;
            }

            .navbar.navbar-default .nav-collapse,
            .navbar.navbar-inverse .nav-collapse {
                transform: translate(-100%,0px);
            }

                .navbar.navbar-default .nav-collapse.in,
                .navbar.navbar-inverse .nav-collapse.in {
                    transform: translate(0px,0px);
                }

                .navbar.navbar-default .nav-collapse.slide-down,
                .navbar.navbar-inverse .nav-collapse.slide-down {
                    transform: translate(0px,-100%);
                }

                .navbar.navbar-default .nav-collapse.in.slide-down,
                .navbar.navbar-inverse .nav-collapse.in.slide-down {
                    transform: translate(0px,0px);
                }
        }
        /*for sidebar*/
        .blogShort {
            border-bottom: 1px solid #ddd;
        }

        .add {
            background: #333;
            padding: 40%;
            height: 300px;
        }

        .nav-sidebar {
            width: 110%;
            padding: 0px 0;
            border-right: 1px solid #ddd;
            border-left: 1px solid #ddd;
        }

            .nav-sidebar a {
                color: black;
                -webkit-transition: all 0.08s linear;
                -moz-transition: all 0.08s linear;
                -o-transition: all 0.08s linear;
                transition: all 0.08s linear;
            }

            .nav-sidebar .active a {
                cursor: default;
                background-color: rgb(111, 84,153);
                color: #fff;
            }

                .nav-sidebar .active a:hover {
                    background-color: rgb(111, 84, 153);
                }

            .nav-sidebar .text-overflow a,
            .nav-sidebar .text-overflow .media-body {
                white-space: nowrap;
                overflow: hidden;
                -o-text-overflow: ellipsis;
                text-overflow: ellipsis;
            }

        .btn-blog {
            color: #ffffff;
            background-color: #0b8fee;
            border-color: #0b8fee;
            border-radius: 0;
            margin-bottom: 0px;
        }

            .btn-blog:hover,
            .btn-blog:focus,
            .btn-blog:active,
            .btn-blog.active,
            .open .dropdown-toggle.btn-blog {
                color: white;
                background-color: #0b8fee;
                border-color: #0b8fee;
            }

        h2 {
            color: #34ca78;
        }

        .margin10 {
            margin-bottom: 10px;
            margin-right: 50px;
        }

        .btn3d {
            position: relative;
            top: 1px;
            border: 0;
            transition: all 40ms linear;
            margin-top: 10px;
            margin-bottom: 10px;
            margin-left: 10px;
        }

            .btn3d:active:focus,
            .btn3d:focus:hover,
            .btn3d:focus {
                -moz-outline-style: none;
                outline: medium none;
            }

            .btn3d:active, .btn3d.active {
                top: 5px;
            }

            .btn3d.btn-danger {
                box-shadow: 0 0 0 1px #b93802 inset, 0 0 0 2px rgba(255,255,255,0.15) inset, 0 8px 0 0 #AA0000, 0 8px 8px 1px rgba(0,0,0,0.5);
                background-color: #D73814;
            }
    </style>
</head>
<body>

    <section class="container">
        <div class="header row">
            <div class="col col-lg-12">
                <header class="clearfix">
                    <section id="banner">
                        <img src="Images/banner1.jpg"
                            alt="banner of the supex.ir"
                            width="100%" />
                    </section>
                    <nav class="navbar">
                        <div class="container">
                            <div class="navbar-header">
                                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar-collapse-3">
                                    <span class="sr-only">Toggle navigation</span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                </button>
                                <a class="navbar-brand" href="#">کندو</a>
                            </div>
                            <div class="collapse navbar-collapse" id="navbar-collapse-3">
                                <ul class="nav navbar-nav navbar-right">
                                    <li>
                                        <li><a href="javascript:setCookie();" target="_blank"><i class="glyphicon glyphicon-off"></i>خروج</a></li>
                                        <li><a href="changePassword.aspx" target="_blank"><i class="glyphicon glyphicon-cog"></i>تغییر رمز عبور</a></li>
                                        <li><a href="javascript:redirect();" target="_blank"><i class="glyphicon glyphicon-user"></i>ورود</a></li>
                                        <li><a href="register.aspx" target="_blank"><i class="glyphicon glyphicon-edit"></i>ثبت نام</a></li>
                                        <li><a href="conference.aspx" target="_blank"><i class="glyphicon glyphicon-book"></i>کنفرانس ها</a></li>
                                        <li><a href="javascript:;"><i class="glyphicon glyphicon-list-alt"></i>موضوعات</a></li>
                                        <li><a href="javascript:;"><i class="glyphicon glyphicon-home"></i>صفحه اصلی</a></li>
                                        <a class="btn btn-default btn-outline btn-circle collapsed" data-toggle="collapse" href="#nav-collapse3" aria-expanded="true" aria-controls="nav-collapse3">جستجو</a>
                                    </li>
                                </ul>
                                <div class="collapse nav navbar-nav nav-collapse slide-down" id="nav-collapse3">
                                    <form class="navbar-form navbar-right" role="search">
                                        <div class="form-group">
                                            <input type="text" class="form-control" placeholder="جستجو..." />
                                        </div>
                                        <button type="submit" class="btn btn-danger"><span class="glyphicon glyphicon-search" aria-hidden="true"></span></button>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </nav>

                    <div class="content row">
                    </div>
                    <div class="col-md-10 blogShort">
                        <h1>INTERNATINAL CNFERENCE ON COMPUTER SCIENCE AND ENGINEERING</h1>
                        <img src="Images/poster1.jpg" alt="post img" class="pull-left img-responsive thumb margin10 img-thumbnail">
                        <article>
                            <p>
                                <br />
                                تاریخ شروع:۳ اسفند ۱۳۹۵   |    تاریخ خاتمه:۴ اسفند ۱۳۹۵
                                <br />
                                <br />
                                کامپیوتر و فناوری اطلاعات
                                <br />
                                <br />
                                وب سایت : /http://ccse2017.iaun.ac.ir<br />
                                <br />
                                ایمیل : ccse2017 [at] iaun.ac.ir<br />
                                <br />
                                Computer Architecture<br />
                                <br />
                                اصفهان-نجف آباد - دانشگاه آزاد اسلامی واحد نجف آباد
                            </p>
                        </article>
                        <a class="btn btn-blog pull-right marginBottom10" href="http://iconf.ir/conferences_info.php?confId=2148">اطلاعات بیشتر...</a>
                    </div>
                    <div class="col-md-10 blogShort">
                        <h1>کنفرانس بین المللی پژوهش های نوین علوم مهندسی</h1>
                        <img src="Images/poster2.jpg" alt="post img" class="pull-left img-responsive thumb margin10 img-thumbnail">
                        <article>
                            <p>
                                <br />
                                تاریخ شروع:۲۴ اسفند ۱۳۹۴ | تاریخ خاتمه:۲۵ اسفند ۱۳۹۴
                                <br />
                                <br />
                                فنی و مهندسی<br />
                                <br />
                                یک هفته کاری پس از ثبت مقاله  : اعلام نتایج داوری
                                <br />
                                <br />
                                دبیرخانه دایمی کنفرانس : برگزارکننده
                                <br />
                                <br />
                                تهران - دانشگاه تهران     
                            </p>
                        </article>
                        <a class="btn btn-blog pull-right marginBottom10" href="http://iconf.ir/conferences_info.php?confId=1866">اطلاعات بیشتر...</a>
                    </div>
                    <div class="col-md-10 blogShort">
                        <h1>اولین همایش ملی فناوری های نوین در علوم مهندسی کامپیوتر و رباتیک</h1>
                        <img src="Images/poster3.jpg" alt="post img" class="pull-left img-responsive thumb margin10 img-thumbnail">
                        <article>
                            <p>
                                <br />
                                تاریخ شروع:۲۰ اسفند ۱۳۹۴ | تاریخ خاتمه:۲۰ اسفند ۱۳۹۴
                                <br />
                                <br />
                                کامپیوتر و فناوری اطلاعات<br />
                                <br />
                                اولین همایش ملی فناوری نوین درعلوم مهندسی کامپیوتر و رباتیک :برگزارکننده<br />
                                <br />
                                میکرو رباتیک و نانو رباتیک
                                <br />
                                <br />
                                رباتهای هوشمند و صنعتی<br />
                                <br />
                                تهران : مکان برگزاری
                            </p>
                        </article>
                        <a class="btn btn-blog pull-right marginBottom10" href="http://iconf.ir/conferences_info.php?confId=1843">اطلاعات بیشتر...</a>
                    </div>
                    <div class="col-md-12 gap10"></div>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <button type="button" class="btn btn-danger btn-sm btn3d"><span class="glyphicon glyphicon-off"></span></button>
            </div>
        </div>
</body>
</html>
