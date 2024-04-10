function rating(evt, attribute) {
    // �������� ��� ����������
    var i, tabcontent, tablinks;
    // �������� ��� �������� � ������� class="tabcontent" � �������� ��
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    // �������� ��� �������� � ������� class="tablinks" � ������� class "active"
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }
    // �������� ������� ������� � �������� "active" ����� ��� ������, ������� ������� �������
    document.getElementById(attribute).style.display = "block";
    evt.currentTarget.className += " active";
}

function wars(evt, attribute) {
    // �������� ��� ����������
    var i, warcontent, warlinks;
    // �������� ��� �������� � ������� class="warcontent" � �������� ��
    warcontent = document.getElementsByClassName("warcontent");
    for (i = 0; i < warcontent.length; i++) {
        warcontent[i].style.display = "none";
    }
    // �������� ��� �������� � ������� class="warlinks" � ������� class "active"
    warlinks = document.getElementsByClassName("warlinks");
    for (i = 0; i < warlinks.length; i++) {
        warlinks[i].className = warlinks[i].className.replace(" active", "");
    }
    // �������� ������� ������� � �������� "active" ����� ��� ������, ������� ������� �������
    document.getElementById(attribute).style.display = "block";
    evt.currentTarget.className += " active";
}