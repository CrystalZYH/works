if($.fn.pagination){$.fn.pagination.defaults.beforePageText="第";$.fn.pagination.defaults.afterPageText="共{pages}页";$.fn.pagination.defaults.displayMsg="显示{from}到{to},共{total}记录"}if($.fn.datagrid){$.fn.datagrid.defaults.loadMsg="正在处理，请稍待。。。"}if($.fn.treegrid&&$.fn.datagrid){$.fn.treegrid.defaults.loadMsg=$.fn.datagrid.defaults.loadMsg}if($.messager){$.messager.defaults.ok="确定";$.messager.defaults.cancel="取消"}if($.fn.validatebox){$.fn.validatebox.defaults.missingMessage="该输入项为必输项";$.fn.validatebox.defaults.rules.email.message="请输入有效的电子邮件地址";$.fn.validatebox.defaults.rules.url.message="请输入有效的URL地址";$.fn.validatebox.defaults.rules.length.message="输入内容长度必须介于{0}和{1}之间";$.fn.validatebox.defaults.rules.remote.message="请修正该字段"}if($.fn.numberbox){$.fn.numberbox.defaults.missingMessage="该输入项为必输项"}if($.fn.combobox){$.fn.combobox.defaults.missingMessage="该输入项为必输项"}if($.fn.combotree){$.fn.combotree.defaults.missingMessage="该输入项为必输项"}if($.fn.combogrid){$.fn.combogrid.defaults.missingMessage="该输入项为必输项"}if($.fn.calendar){$.fn.calendar.defaults.weeks=["日","一","二","三","四","五","六"];$.fn.calendar.defaults.months=["一月","二月","三月","四月","五月","六月","七月","八月","九月","十月","十一月","十二月"]}if($.fn.datebox){$.fn.datebox.defaults.currentText="今天";$.fn.datebox.defaults.closeText="关闭";$.fn.datebox.defaults.okText="确定";$.fn.datebox.defaults.missingMessage="该输入项为必输项";$.fn.datebox.defaults.formatter=function(D){var C=D.getFullYear();var B=D.getMonth()+1;var A=D.getDate();return C+"-"+(B<10?("0"+B):B)+"-"+(A<10?("0"+A):A)};$.fn.datebox.defaults.parser=function(B){if(!B){return new Date()}var A=B.split("-");var E=parseInt(A[0],10);var D=parseInt(A[1],10);var C=parseInt(A[2],10);if(!isNaN(E)&&!isNaN(D)&&!isNaN(C)){return new Date(E,D-1,C)}else{return new Date()}}}if($.fn.datetimebox&&$.fn.datebox){$.extend($.fn.datetimebox.defaults,{currentText:$.fn.datebox.defaults.currentText,closeText:$.fn.datebox.defaults.closeText,okText:$.fn.datebox.defaults.okText,missingMessage:$.fn.datebox.defaults.missingMessage})};