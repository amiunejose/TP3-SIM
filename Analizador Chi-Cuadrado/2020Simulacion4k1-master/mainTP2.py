from tp2.exports.ToExcel import ToExcel
from tp2.TestChiCuadrado import TestChiCuadradoTp2


ACCURACY = 4
# tests
# filename = 'PruebaUniforme.txt'
# filename = 'PruebaNormal.txt'
# filename = 'PruebaExponencial.txt'
# filename = 'PruebaPoisson.txt'

filename = 'C:\\Users\\jose_\\OneDrive\\Escritorio\\Jose\\Facultad\\GitHub\\TP3-SIM\\GeneradorDeDistribuciones\\bin\\Debug\\data.txt'
xls_name = 'test_chi2_prueba'

with open(filename, 'r') as f:
    line = f.readline().split(';')
    random_numbers = [float(i) for i in line]
    _type = int(f.readline())
    intervals = int(f.readline())
    lim_inf = float(min(random_numbers))
    lim_sup = float(max(random_numbers))

t = TestChiCuadradoTp2(random_numbers, ACCURACY)
t.do_test(lim_inf, lim_sup, _type, intervals)

ToExcel.create_excel(t, xls_name)
print("Test de Chi-Cuadrado finalizado con exito")